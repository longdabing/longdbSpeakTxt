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
            string sql = "select FNo from TUser where FName='"+name+ "' and FPwd='"+pwd+"'";
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
    }
}
