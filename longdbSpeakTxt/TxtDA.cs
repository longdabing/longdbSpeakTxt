using longdbSpeakTxt.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longdbSpeakTxt
{
    public class TxtDA
    {
        private static IDBUtil dBUtil = DBFactory.SingelDBFactory(DBType.access);
        public static DataTable GetUser(string name,string pwd)
        {
            string sql = "select FNo from TUser where FName='" + name + "' and FPwd='" + pwd + "'";
            return dBUtil.Querry(sql);
        }
        public static DataTable GetPoetryTable(string title)
        {
            string sql = @"select FMNo,FTitle,detail.FLine1,detail.FLine2,detail.FLine3,detail.FLine4,
 detail.FLine5,detail.FLine6,detail.FLine7,detail.FLine8 from TPoetry as main 
        left join TPoetryDetail as detail on detail.FMNo=main.FNo";
            if (!string.IsNullOrEmpty(title))
            {
                sql += " where FTitle='" + title + "'";
            }
            return dBUtil.Querry(sql);
        }
        public static int CreatePoetry(DataTable maindt,DataTable detaildt)
        {
            string mno = Guid.NewGuid().ToString();
            string msql = @"insert TPoetry(FNo,FTitle,FAuther) " +
                "values('"+ mno + "'," +
                "'"+ maindt.Rows[0]["no"].ToString() + "'," +
                "'"+ maindt.Rows[0]["no"].ToString() + "'," +
                "'"+ maindt.Rows[0]["no"].ToString() + "'," +
                "'"+ maindt.Rows[0]["no"].ToString() + "')";

            string dsql = @"insert TPoetryDetail(FMNo,FLine1,FLine2,FLine3,FLine4) " +
               "values('" + mno + "'," +
               "'" + detaildt.Rows[0]["line1"].ToString() + "'," +
               "'" + detaildt.Rows[0]["line2"].ToString() + "'," +
               "'" + detaildt.Rows[0]["line3"].ToString() + "'," +
               "'" + detaildt.Rows[0]["line4"].ToString() + "')";
            int retvalue = dBUtil.Execute(msql);
            retvalue += dBUtil.Execute(dsql);
            return retvalue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mdt">主表</param>
        /// <param name="mtablename">主表表名</param>
        /// <param name="ddt">子表</param>
        /// <param name="dtablename">子表表名</param>
        /// <returns></returns>
        public static int Update(DataTable mdt,string mtablename, DataTable ddt,string dtablename,bool isupdate=false)
        {
            int retvalue = 0;
            string msql = @"SELECT  FNo, FTitle
             FROM  "+ mtablename + " WHERE FNo = '';";
            string dsql = "select * from " + dtablename + " WHERE FMNo = ''";
            if (isupdate)
            {
             //   msql = @"SELECT  FNo, FTitle
             //FROM  " + mtablename + " WHERE FNo = '"+mdt.Rows[0]["FNo"].ToString()+"'";
             //   dsql = "select * from " + dtablename + " WHERE FMNo = '"+ddt.Rows[0]["FMNo"].ToString()+"'";
                for (int i = 0; i < mdt.Rows.Count; i++)
                {
                    mdt.Rows[i][0] = mdt.Rows[i][0];
                    mdt.AcceptChanges();
                    mdt.Rows[i].SetModified();
                }

                DataRowState rowState = ddt.Rows[0].RowState;
                for (int i = 0;i < ddt.Rows.Count; i++)
                {
                    ddt.Rows[i][1] = ddt.Rows[i][1];
                    ddt.AcceptChanges();
                    ddt.Rows[i].SetModified();
                }
                rowState = ddt.Rows[0].RowState;
            }
            try
            {
                dBUtil.OpenConn();
                dBUtil.BeginTrans();
                retvalue = dBUtil.Update(mdt, msql);
                retvalue += dBUtil.Update(ddt, dsql);
                dBUtil.CommitTrans();
            }
            catch (Exception ex)
            {
                dBUtil.RollbackTrans();
            }
            finally
            {
                dBUtil.CloseConn();
            }
            return retvalue;
        }
    }
}
