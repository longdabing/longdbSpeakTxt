using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longdbSpeakTxt.Tools
{
    public class AccessUtil : IDBUtil
    {
        private static AccessUtil accessUtil = null;
        private static string connstr = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = DataBase\longdb.mdb";
        OleDbConnection conn = null;// new OleDbConnection();
        private AccessUtil()
        { }
        public static AccessUtil SingleSqlDBUtil()
        {
            if (accessUtil == null)
            {
                accessUtil = new AccessUtil();
                return accessUtil;
            }
            else
            {
                return accessUtil;
            }
        }
        public void BeginTrans()
        {
            throw new NotImplementedException();
        }

        public void CloseConn()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        public void CommitTrans()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 插入，更新，删除。
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Execute(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            return cmd.ExecuteNonQuery(); //返回受影响的行数。
        }

        public void OpenConn()
        {
            if (conn == null)
            {
                conn = new OleDbConnection(connstr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
        }

        public DataTable Querry(string sql)
        {
            DataTable retdt = new DataTable();
            try
            {
                OpenConn();
                OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(sql, conn); //创建适配对象
                dbDataAdapter.Fill(retdt); //用适配对象填充表对象
            }
            catch (Exception ex)
            { }
            finally
            {
                CloseConn();
            }
            return retdt;
        }

        public void RollbackTrans()
        {
            throw new NotImplementedException();
        }

        public int SqlBulkInsert(DataTable dt, string tablename)
        {
            throw new NotImplementedException();
        }

        public int Update(DataTable table, string sql)
        {
            throw new NotImplementedException();
        }
    }
}
