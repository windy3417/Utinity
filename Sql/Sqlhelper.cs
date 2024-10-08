﻿using System;
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
            it,
            ufsystem
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
        public static SqlConnection sqlConnection(DataSourceType dataSourceType, string accountNo="")
        {
                      
            string connectedKey;
        

            if (dataSourceType == DataSourceType.u8 && accountNo != "")
            {
                connectedKey = Enum.GetName(typeof(DataSourceType), DataSourceType.u8);
                return ConnectString(connectedKey+accountNo);
                //conString = ConfigurationManager.ConnectionStrings[connectedKey].ToString();
                //deConString = Encrypt.Decode(conString);

                //sqlConnection = new SqlConnection(deConString);

                //return sqlConnection;
            }

            if (dataSourceType == DataSourceType.ufsystem)
            {
                connectedKey = Enum.GetName(typeof(DataSourceType), DataSourceType.ufsystem);
                return ConnectString(connectedKey);
                //conString = ConfigurationManager.ConnectionStrings[connectedKey].ToString();
                //deConString = Encrypt.Decode(conString);

                //sqlConnection = new SqlConnection(deConString);

                //return sqlConnection;
            }

            if (dataSourceType == DataSourceType.it)
            {
                connectedKey = Enum.GetName(typeof(DataSourceType), DataSourceType.it);
                return ConnectString(connectedKey);
                //conString = ConfigurationManager.ConnectionStrings[connectedKey].ToString();
                //deConString = Encrypt.Decode(conString);

                //sqlConnection = new SqlConnection(deConString);

                //return sqlConnection;
            }

            if (dataSourceType == DataSourceType.plug)
            {
                connectedKey = Enum.GetName(typeof(DataSourceType), DataSourceType.plug);
                return ConnectString(connectedKey);
                //conString = ConfigurationManager.ConnectionStrings[connectedKey].ToString();
                //deConString = Encrypt.Decode(conString);

                //sqlConnection = new SqlConnection(deConString);

                //return sqlConnection;
            }

            if (dataSourceType == DataSourceType.business)
            {
                connectedKey = Enum.GetName(typeof(DataSourceType), DataSourceType.business);
                return ConnectString(connectedKey);

            }

                return null;

           

        }

        /// <summary>
        /// DECRYPTION CONNECTION STRING
        /// </summary>
        /// <param name="connectedKey"></param>
        /// <returns></returns>
        private static SqlConnection ConnectString( string connectedKey)
        {
           string encryptedString = ConfigurationManager.ConnectionStrings[connectedKey].ToString();
           string deConString = Encrypt.Decode(encryptedString);

           SqlConnection  sqlConnection = new SqlConnection(deConString);

            return sqlConnection;
        }

        #endregion

        #region 返回DataTable
        /// <summary>
        /// 动态数据源，返回查询结果
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="dataSourceType"></param>
        /// <returns></returns>

        public static DataTable GetDataTable(string strSql, DataSourceType dataSource)
        {

            using (SqlConnection conn = sqlConnection(dataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @strSql;

                  
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }

            }
        }


        public static DataTable GetDataTable(string strSql, SqlParameter[] sqlParameters, DataSourceType dataSource)
        {

            using (SqlConnection conn = sqlConnection(dataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;
                    foreach (SqlParameter p in sqlParameters)
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



        #endregion



        #region 返回SqlDataReader

        /// <summary> 
        /// 返回sqlDataReader 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="dataSourceType">数据源类型</param>
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static SqlDataReader GetSqlDataReader(string strSql, SqlParameter[] parameters, DataSourceType dataSourceType,string accountNo="")
        {
            SqlConnection connection;
            if (accountNo != "")
            {
                connection = sqlConnection(dataSourceType,accountNo);
            }
            else
            {
                connection = sqlConnection(dataSourceType);
            }   
      
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


            cmd.Parameters.Clear();//多了这一句，就解决了问题; 不然，当连续调用该方法时，则报另一个SqlParameterCollection中已包含SqlParameter的错误。
            return reader;



        }


        /// <summary> 
        /// 返回sqlDataReader 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="dataSourceType">数据源类型</param>
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static SqlDataReader GetSqlDataReader(string strSql, DataSourceType dataSourceType,string accountNo="")
        {

            SqlConnection connection;
            if (accountNo != "")
            {
                connection = sqlConnection(dataSourceType, accountNo);
            }
            else
            {
                connection = sqlConnection(dataSourceType);
            }
            connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = strSql;


            
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;




        }

        #endregion



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
        public static bool ExecuteWithNoneParameter(string SQLstring, DataSourceType dataSourceType)
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

        #region transation
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

                    MessageBox.Show("事务执行失败" + ex.Message + ex.InnerException, "事务执行提示");
                    return false;



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
                        MessageBox.Show("事务回滚失败" + ex2.Message + ex2.InnerException, "事务执行提示");
                    }
                }
            }
        }

        public static bool ExecuteSqlTransaction(string SQLstring, SqlParameter[] sqlParameters, DataSourceType dataSourceType)
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
                    command.Parameters.AddRange(sqlParameters);
                    command.ExecuteNonQuery();


                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return true;

                }


                catch (Exception ex)
                {

                    MessageBox.Show("事务执行失败" + ex.Message + ex.InnerException, "事务执行提示");
                    return false;



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
                        MessageBox.Show("事务回滚失败" + ex2.Message + ex2.InnerException, "事务执行提示");
                    }
                }
            }
        }


        #endregion



        /// <summary>
        /// 带参数执行对数据的增删改操作
        /// </summary>
        /// <param name="SQLstring"></param>
        public static int UpdateWithparameters(string SQLstring, DataSourceType dataSourceType, SqlParameter[] sqlParameters)
        {

            using (SqlConnection connection = sqlConnection(dataSourceType))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = SQLstring;

                cmd.Parameters.AddRange(sqlParameters);
                int influnce = cmd.ExecuteNonQuery();

                connection.Close();
                return influnce;
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

        public DataTable GetAddresBookAsDataTable(SqlParameter[] sqlParameters)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select * from addressBook where  1=1 ");

            if (sqlParameters == null)
            {

                return Sqlhelper.GetDataTable(sql.ToString(), Sqlhelper.DataSourceType.it);
            }

            else
            {
                foreach (var item in sqlParameters)
                {

                    sql.Append($" and {item.ParameterName.Replace("@", "")}= {item.ParameterName}");

                }
                return Sqlhelper.GetDataTable(sql.ToString(), sqlParameters, Sqlhelper.DataSourceType.it);
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







