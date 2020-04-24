using System.Data;

namespace longdbSpeakTxt.Tools
{
    public interface IDBUtil
    {
        void OpenConn();
        void CloseConn();
        void BeginTrans();
        void CommitTrans();
        void RollbackTrans();
        /// <summary>
        /// 单条插入数据，删除，更新。
        /// </summary>
        int Execute(string sql);
        /// <summary>
        /// 单表批量插入。
        /// </summary>
        int SqlBulkInsert(DataTable dt, string tablename);
        /// <summary>
        /// 单表批量插入或者更新数据
        /// </summary>
        int Update(DataTable table,string sql);

        /// <summary>
        /// 主表和子表批量插入或者更新数据
        /// </summary>
        //int Update(DataTable firsttable,DataTable secondtable,string firstsql,string secondsql);
        /// <summary>
        /// 
        /// </summary>
        DataTable Querry(string sql);
    }
}
