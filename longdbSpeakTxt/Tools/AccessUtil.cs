using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longdbSpeakTxt.Tools
{
    public class AccessUtil : IDBUtil
    {
        private static AccessUtil accessUtil = null;
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
            throw new NotImplementedException();
        }

        public void CommitTrans()
        {
            throw new NotImplementedException();
        }

        public int Execute(string sql)
        {
            throw new NotImplementedException();
        }

        public void OpenConn()
        {
            throw new NotImplementedException();
        }

        public DataTable Querry(string sql)
        {
            throw new NotImplementedException();
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
