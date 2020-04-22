using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longdbSpeakTxt.Tools
{
    public class DBFactory
    {
        //public DBType dbType = 0;
        private DBFactory dBFactory = null;
        private IDBUtil dBUtil = null;
        /// <summary>
        /// 构造函数注入。
        /// </summary>
        /// <param name="dbType"></param>
        private DBFactory(DBType dbType)
        {
            switch (dbType)
            {
                case DBType.sql:
                    dBUtil = SqlDBUtil.SingleSqlDBUtil();
                    break;
                case DBType.access:
                    dBUtil = AccessUtil.SingleSqlDBUtil();
                    break;
                default:
                    dBUtil = SqlDBUtil.SingleSqlDBUtil();
                    break;
            }
        }
        public IDBUtil SingelDBFactory(DBType dbType)
        {
            if (dBFactory == null)
            {
                dBFactory = new DBFactory(dbType);
                return dBUtil;
            }
            else
            {
                return dBUtil;
            }
        }
    }
}
