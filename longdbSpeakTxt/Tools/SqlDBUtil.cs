using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longdbSpeakTxt.Tools
{
    public class SqlDBUtil:IDBUtil
    {
        private static SqlTransaction trans = null;
        private static SqlConnection conn = null;
        private static string connstr = "";
        private static object lockobj = new object();
        private static SqlDBUtil sqlDBUtil = null;
        private SqlDBUtil()
        { }
        public static SqlDBUtil SingleSqlDBUtil()
        {
            if (sqlDBUtil == null)
            {
                sqlDBUtil = new SqlDBUtil();
                return sqlDBUtil;
            }
            else
            {
                return sqlDBUtil;
            }
        }
        public void OpenConn()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connstr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
        }
        public void CloseConn()
        {
            if (conn != null && conn.State == connState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        public void BeginTrans()
        {
            if (trans == null)
            {
                trans = conn.BeginTransaction();
            }
        }

        public  void CommitTrans()
        {
            if (trans != null)
            {
                trans.Commit();
                trans.Dispose();
                trans = null;
            }
        }

        public void RollbackTrans()
        {
            if (trans != null)
            {
                trans.Rollback();
                trans.Dispose();
                trans = null;
            }
        }
        public  int Update(DataTable dt, string sql)
        {
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = new SqlCommand(sql, conn, trans);

            SqlCommandBuilder custCB = new SqlCommandBuilder(myDataAdapter);
            custCB.ConflictOption = ConflictOption.OverwriteChanges;
            custCB.SetAllValues = true;

            foreach (DataRow dr in dt.Rows)
            {
                if (dr.RowState == DataRowState.Unchanged)
                {
                    if (ismain)
                    {
                        dr.SetModified();
                    }
                    else
                    {
                        dr.SetAdded();
                    }
                }
            }
            int retvalue = 0;
            try
            {
                retvalue = myDataAdapter.Update(dt);
                dt.AcceptChanges();
                myDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                //CBase.AddErroLog("DBConn.Update:(" + DateTime.Now.ToString() + ")" + ex.ToString() + " sql:" + sql);
            }
            return retvalue;
        }
        /// <summary>
        /// 单条插入，更新，删除。
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public  int Execute(string sql)
        {
            int retvalue = 0;
            lock (lockobj)
            {
                OpenConn();
                BeginTrans();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.Transaction = trans;
                    retvalue = cmd.ExecuteNonQuery();
                    if (retvalue == 0)
                    {
                        RollbackTrans();//回滚
                    }
                    else
                    {
                        CommitTrans();//提交事务。
                    }
                    cmd.Dispose();

                    return retvalue;
                }
                catch (Exception)
                {
                    RollbackTrans();//回滚
                    return retvalue;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public int SqlBulkInsert(DataTable dt, string tablename)
        {
            int result = 0;
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(conn, SqlBulkCopyOptions.KeepIdentity, trans);
                bulkCopy.DestinationTableName = tablename;
                bulkCopy.BatchSize = dt.Rows.Count;
                foreach (DataColumn dc in dt.Columns)
                {
                    bulkCopy.ColumnMappings.Add(dc.ColumnName, dc.ColumnName);//将table中的列与数据库表这的列一一对应
                }
                try
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        bulkCopy.WriteToServer(dt);
                        result = 1;
                    }
                }
                catch (Exception ex)
                {
                    //CBase.AddErroLog("DBConn.sqlBulkCopyBatch:(" + DateTime.Now.ToString() + ")" + ex.ToString());
                    bulkCopy.Close();
                }
                finally
                {
                    bulkCopy.Close();
                }
            }
            return result;
        }

        public DataTable Querry(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConn();
                SqlDataAdapter sdd = new SqlDataAdapter(sql, conn);
                sdd.Fill(dt);
            }
            catch (Exception)
            {
                //return dt;
            }
            finally
            {
                CloseConn();
            }
            return dt;
        }
        /// <summary>
        /// 执行存储过程，获取输出参数的值。
        /// </summary>
        public  string ExecuteNonQueryProcedure(SqlParameter[] param)
        {
            string retvalue = string.Empty;
            try
            {
                OpenConn();
                BeginTrans();
                string sql = "usp_GetGreigeRollNo";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandTimeout = 50;
                comm.CommandType = CommandType.StoredProcedure;//存储过程

                //SqlParameter[] parameters = new SqlParameter[3];
                //parameters[0] = new SqlParameter("@recno", SqlDbType.VarChar);
                //parameters[1] = new SqlParameter("@grollno", SqlDbType.VarChar, 50);//输出参数必须指定参数大小。
                //parameters[1].Direction = ParameterDirection.Output;//参数输出值。输出值不需要对Value属性赋值。
                //parameters[2] = new SqlParameter("@trans", SqlDbType.VarChar);

                ////输入参数,需要赋值
                //parameters[0].Value = "longdb001";
                //parameters[2].Value = "0";

                comm.Parameters.AddRange(param);//把数组参数添加到SqlCommand
                comm.ExecuteNonQuery();
                CommitTrans();
                return retvalue;
            }
            catch (Exception ex)
            {
                RollbackTrans();
                return retvalue; ;
            }
            finally
            {
               CloseConn() ;
            }
        }

        /// <summary>
        /// 执行存储过程，获取输出参数的值。
        /// </summary>

        public  int ExecuteProcedure(string StoredProcedure, SqlParameter[] parameters,int timeout=5000)
        {
            int retvalue = 0;
            try
            {
                OpenConn();
                BeginTrans();
                SqlCommand comm = new SqlCommand(StoredProcedure, conn);
                comm.CommandTimeout = timeout;
                comm.CommandType = CommandType.StoredProcedure;//存储过程
                comm.Parameters.AddRange(parameters);//把数组参数添加到SqlCommand

                retvalue = comm.ExecuteNonQuery();
                CommitTrans();
                return retvalue;

            }
            catch (Exception ex)
            {
                RollbackTrans();
                return retvalue; ;
            }
            finally
            {
                CloseConn();
            }
        }
    }
}
