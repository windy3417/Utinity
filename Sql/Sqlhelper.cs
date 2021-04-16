using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Utility.Sql
{
    public class Sqlhelper
    {
                       
        #region 动态数据源增删改查

        /// <summary>
        /// 数据源类型枚举
        /// </summary>
        public enum DataSourceType
        {
            u8,
            plug,
            business,
            it
        }

        #region 数据库连接


        /// <summary>
        /// 返回sqlConnection，
        /// 业务数据源连接字符串名称是“business”,
        /// 外挂数据源连接字符串名称是“plug",
        /// U8数据源连接字符串名称是“u8"
        /// 运维数据源连接字符串名称是“it"
        /// 与数据源枚举一致
        /// </summary>
        /// <param name="dataSourceType" >
        /// 数据源类型
        /// </param>
        /// <returns></returns>
        public static SqlConnection sqlConnection(DataSourceType dataSourceType)
        {
            
            string conString;
            string deConString;
            SqlConnection sqlConnection;

            if (dataSourceType == DataSourceType.u8)
            {
                string connectedKey = Enum.GetName(typeof(DataSourceType), DataSourceType.u8);
                conString = ConfigurationManager.ConnectionStrings[connectedKey].ToString();
                deConString = Encrypt.Decode(conString);

                sqlConnection = new SqlConnection(deConString);

                return sqlConnection;
            }

            if (dataSourceType == DataSourceType.it)
            {
                string connectedKey = Enum.GetName(typeof(DataSourceType), DataSourceType.it);
                conString = ConfigurationManager.ConnectionStrings[connectedKey].ToString();
                deConString = Encrypt.Decode(conString);

                sqlConnection = new SqlConnection(deConString);

                return sqlConnection;
            }
            else
            {
                if (dataSourceType == DataSourceType.plug)
                {
                    string connectedKey = Enum.GetName(typeof(DataSourceType), DataSourceType.plug);
                    conString = ConfigurationManager.ConnectionStrings[connectedKey].ToString();
                    deConString = Encrypt.Decode(conString);

                    sqlConnection = new SqlConnection(deConString);

                    return sqlConnection;
                }
                
                conString = ConfigurationManager.ConnectionStrings[Enum.GetName(typeof(DataSourceType), DataSourceType.business)].ToString();
                deConString = Encrypt.Decode(conString);

                sqlConnection = new SqlConnection(deConString);

                return sqlConnection;
            }









        }

        #endregion

        /// <summary>
        /// 动态数据源，返回查询结果
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="dataSourceType"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string strSql, DataSourceType dst)
        {

            using (SqlConnection conn = sqlConnection(dst))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;

                    DataSet ds = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                        conn.Close();
                        return ds.Tables[0];
                    }
                }

            }
        }

        /// <summary> 
        /// 返回sqlDataReader 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="dataSourceType">数据源类型</param>
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static SqlDataReader GetSqlDataReader(string strSql, DataSourceType dataSourceType, SqlParameter[] parameters)
        {

            SqlConnection connection = sqlConnection(dataSourceType);
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = strSql;

            cmd.Parameters.AddRange(parameters);
            //执行完后不能调用sqlconection.close方法去关闭连接，否则sqldatareader对象无法调用
            //其read方法，采用commandBehavior.closeConection枚举可在关闭sqldatareader时自动
            //关闭SqlConnection,同时也说明Command.ExecuteReader方法并未执行真正的查询，仅仅是
            //构造SqlDataReader对象
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;

                                   

        }


        /// <summary> 
        /// 返回sqlDataReader 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="dataSourceType">数据源类型</param>
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static SqlDataReader GetSqlDataReader(string strSql, DataSourceType dataSourceType)
        {

            SqlConnection connection = sqlConnection(dataSourceType);
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = strSql;

                      
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;

                      


        }


        /// <summary>
        /// 执行外挂数据库的存储过程
        /// </summary>
        /// <param name="conn">数据库连接对象</param>
        /// <param name="StoredProcedureName">存储过程名称</param>
        /// <param name="parameters">存储过程参数</param>
        public DataTable ExecuteProc(SqlConnection conn, string StoredProcedureName, SqlParameter[] parameters)
        {


            conn.Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedureName;
                foreach (SqlParameter p in parameters)
                {
                    cmd.Parameters.Add(p);
                }
                DataSet ds = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                    conn.Close();
                    return ds.Tables[0];
                }
            }

        }


        /// <summary>
        /// 数据库及表结构的创建
        /// </summary>
        /// <param name="SQLstring"></param>
        /// <param name="dataSourceType" >数据源类型</param>
        /// <returns>执行结果成功标志</returns>
        public static bool  ExecuteWithNoneParameter(string SQLstring,DataSourceType dataSourceType)
        {
            try
            {
                SqlConnection connection = sqlConnection(dataSourceType);
                connection.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = SQLstring;

                cmd.ExecuteNonQuery();

                connection.Close();
                return true;
               
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + e.InnerException, "数据库执行出错");
                return false;
                
            }

           
        }

       

        //暂用于创建数据表的事务
        /// <summary>
        /// 数据库及表结构的创建
        /// </summary>
        /// <param name="SQLstring"></param>
        /// <param name="dataSourceType" >数据源类型</param>
        /// <returns>执行结果成功标志</returns>
        public static bool ExecuteSqlTransaction(string SQLstring, DataSourceType dataSourceType)
        {
            using (SqlConnection connection = sqlConnection(dataSourceType))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = SQLstring;
                       
                    command.ExecuteNonQuery();
                   

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return true;
                   
                }
                catch (Exception ex)
                {
                    return false;
                    MessageBox.Show("事务执行失败" +ex.Message+ex.InnerException, "事务执行提示");
                   

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        MessageBox.Show("事务回滚失败" + ex.Message + ex.InnerException, "事务执行提示");
                    }
                }
            }
        }

        #endregion

        #region 单一数据源增删改查询
        /// <summary>
        /// 返回sqlConnection，默认连接字符串名称是“businessConection”
        /// </summary>
        /// <returns></returns>

        public static SqlConnection sqlConnection()
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["businessConection"].ToString();

                string deConString = Encrypt.Decode(conString);
                //ConnectionStringSettings conStrings = new ConnectionStringSettings("busynessDate", deConString);
                SqlConnection sqlConnection = new SqlConnection(deConString);

                return sqlConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接出错" + ex.Message + ex.InnerException);
                return null;
            }


        }
              #region 查询
        /// <summary> 
        /// 带参数执行查询并将结果返回至DataTable中 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="parameters">查询参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static DataTable GetDataTable(string strSql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = sqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    DataSet ds = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                        conn.Close();
                        return ds.Tables[0];
                    }

                }

            }
        }

        /// <summary> 
        /// 不带查询参数执行查询并将结果返回至DataTable中
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <returns>返回一张查询结果表</returns> 

        public static DataTable GetDataTable(string strSql)
        {

            using (SqlConnection conn = sqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;

                    DataSet ds = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                        conn.Close();
                        return ds.Tables[0];
                    }
                }

            }
        }

        

        /// <summary> 
        /// 返回sqlDataReader 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static SqlDataReader GetSqlDataReader(string strSql, SqlParameter[] parameters)
        {

            SqlConnection connection = sqlConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = strSql;

            cmd.Parameters.AddRange(parameters);
            //执行完后不能调用sqlconection.close方法去关闭连接，否则sqldatareader对象无法调用
            //其read方法，采用commandBehavior.closeConection枚举可在关闭sqldatareader时自动
            //关闭SqlConnection,同时也说明Command.ExecuteReader方法并未执行真正的查询，仅仅是
            //构造SqlDataReader对象
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;






        }
        #endregion

              #region 增删改

        /// <summary>
        /// 不带参数执行对数据的增删改操作
        /// </summary>
        /// <param name="SQLstring"></param>
        public static void UpdateNOparameters(SqlConnection conn, string SQLstring)
        {


            conn.Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = SQLstring;

                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }


        /// <summary>
        /// 不带参数执行对数据的增删改操作
        /// </summary>
        /// <param name="SQLstring"></param>
        public static int UpdateWithparameters(string SQLstring, SqlParameter[] sqlParameters)
        {


            SqlConnection connection = sqlConnection();
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = SQLstring;

            cmd.Parameters.AddRange(sqlParameters);
            int influnce = cmd.ExecuteNonQuery();

            connection.Close();
            return influnce;
        }


        ///<summary> 
        /// 执行对数据的增删改操作 
        /// </summary> 
        /// <param name="strSql"></param> 
        /// <param name="parameters"></param> 
        public static void ExecuteNonQuery(SqlConnection conn, string strSql, params SqlParameter[] parameters)
        {


            conn.Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = strSql;
                foreach (SqlParameter p in parameters)
                {
                    cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        #endregion

        #endregion





    }





}







