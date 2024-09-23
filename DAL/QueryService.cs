using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Utility.Sql;
using static Utility.Sql.Sqlhelper;

namespace Utility.DAL
{
    public static class QueryService
    {

        #region single table query
        /// <summary>
        /// query single table without parameters
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static List<TEntity> GetListFromSingleTable<TEntity>(DataSourceType dataSource,string accountNo="") where TEntity : class, new()
        {
            TEntity model = new TEntity();
            List<TEntity> entityList = new List<TEntity>();
            Type modelType = model.GetType();
            string tableName = modelType.Name.Replace("Model", "");
            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");
            SqlDataReader sqlDataReader;


            PropertyInfo[] proInfo = modelType.GetProperties();
            if (accountNo != "")
            {
                sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), dataSource,accountNo);
            }
            else
            {
                sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), dataSource);
            }

            while (sqlDataReader.Read())
            {
                #region 赋值给单一实体
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface)
                    {

                        //处理空值
                        if (sqlDataReader[propertyName] is DBNull)
                        {
                            item.SetValue(m, null, null);
                        }
                        else
                        {
                            item.SetValue(m, sqlDataReader[propertyName], null);
                        }

                    }

                }

                entityList.Add(m);



                #endregion

            }

            return entityList;



        }

        /// <summary>
        /// select single table with parameter
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static List<TEntity> GetListFromSingleTable<TEntity>(SqlParameter[] sqlParameters, DataSourceType dataSource,string U8AccountNo="") where TEntity : class, new()
        {
            TEntity model = new TEntity();
            List<TEntity> entityList = new List<TEntity>();
            Type modelType = model.GetType();
            string tableName = modelType.Name.Replace("Model", "");
            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");

            SqlDataReader sqlDataReader;
            foreach (var para in sqlParameters)
            {
                sql.Append($"  and {para.ParameterName.Replace("@", "")}='{para.Value}'");
            }

            PropertyInfo[] proInfo = modelType.GetProperties();

            if (U8AccountNo != "")
            {
                sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(),sqlParameters, dataSource, U8AccountNo);
            }
            else
            {
                sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(),sqlParameters, dataSource);
            }

        
            while (sqlDataReader.Read())
            {
                #region 赋值给单一实体
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface &
                        !propertyName.EndsWith("Header") & !item.PropertyType.Name.EndsWith("Header")
                       &
                        !propertyName.EndsWith("Archive") & !item.PropertyType.Name.EndsWith("Archive"))
                    {



                        //处理空值
                        if (sqlDataReader[propertyName] is DBNull)
                        {
                            item.SetValue(m, null, null);
                        }
                        else
                        {
                            item.SetValue(m, sqlDataReader[propertyName], null);
                        }
                    }

                }

                entityList.Add(m);



                #endregion

            }

            return entityList;



        }

        public static List<TEntity> GetSingleTable<TEntity>(string[] columns, string fullTextSearchString,DataSourceType dataSource) where TEntity : class, new()
        {
            TEntity model = new TEntity();
            List<TEntity> entityList = new List<TEntity>();
            Type modelType = model.GetType();
            string tableName = modelType.Name.Replace("Model", "");
            StringBuilder sqlColumns = new StringBuilder("(");
            foreach (var item in columns)
            {
                sqlColumns.Append(item+",");
            }
            int i = sqlColumns.ToString().Count();
            sqlColumns.Remove(i,1);
            sqlColumns.Append(")");
            StringBuilder sql = new StringBuilder($"select * from {tableName} where contains({columns},'{fullTextSearchString}')");


            PropertyInfo[] proInfo = modelType.GetProperties();


            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), dataSource);
            while (sqlDataReader.Read())
            {
                #region 赋值给单一实体
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface)
                    {

                        //处理空值
                        if (sqlDataReader[propertyName] is DBNull)
                        {
                            item.SetValue(m, null, null);
                        }
                        else
                        {
                            item.SetValue(m, sqlDataReader[propertyName], null);
                        }

                    }

                }

                entityList.Add(m);



                #endregion

            }

            return entityList;



        }

      

        /// <summary>
        /// select single table with parameter
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static List<TEntity> GetDataList<TEntity>( DataSourceType dataSource) where TEntity : class, new()
        {

           
            TEntity model = new TEntity();
            List<TEntity> entityList = new List<TEntity>();
            Type modelType = model.GetType();
            string tableName = modelType.Name.Replace("Model", "");
            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");

          
           

            PropertyInfo[] proInfo = modelType.GetProperties();


            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), dataSource);
            while (sqlDataReader.Read())
            {
                #region 赋值给单一实体
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface
                         & !propertyName.EndsWith("Detail") & !item.PropertyType.Name.EndsWith("Detail") &
                         !propertyName.EndsWith("Header") & !item.PropertyType.Name.EndsWith("Header"))
                    {

                        //处理空值
                        if (sqlDataReader[propertyName] is DBNull)
                        {
                            item.SetValue(m, null, null);
                        }
                        else
                        {
                            item.SetValue(m, sqlDataReader[propertyName], null);
                        }
                    }

                }

                entityList.Add(m);



                #endregion

            }

            return entityList;



        }

        /// <summary>
        /// 单表全数参数化查询
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static List<TEntity> GetDataList<TEntity>(List<SqlParameter> sqlParameters, DataSourceType dataSource, string accountNo = "") where TEntity : class, new()
        {
            TEntity model = new TEntity();
            List<TEntity> entityList = new List<TEntity>();
            Type modelType = model.GetType();
            string tableName = modelType.Name.Replace("Model", "");
            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");
            SqlDataReader sqlDataReader;
            foreach (var para in sqlParameters)
            {
                sql.Append($"  and {para.ParameterName.Replace("@", "")}='{para.Value}'");
            }

            PropertyInfo[] proInfo = modelType.GetProperties();

            if (accountNo != "")
            {
                sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), sqlParameters.ToArray(), dataSource);
            }
            else
            {
                sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), sqlParameters.ToArray(), dataSource);
            }

            while (sqlDataReader.Read())
            {
                #region 赋值给单一实体
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    var typeName = item.PropertyType.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface)
                    {


                        try
                        {
                            if (sqlDataReader[propertyName] is null)
                            {
                                item.SetValue(m, null, null);
                            }
                            else
                            {
                                item.SetValue(m, sqlDataReader[propertyName], null);
                            }

                        }
                        catch (Exception)
                        {
                            if (item.PropertyType.Name == "Nullable`1")
                            {
                                item.SetValue(m, null, null);

                            }
                            else
                            {
                                item.SetValue(m, "", null);
                            }

                        }
                    }

                }

                entityList.Add(m);



                #endregion

            }

            return entityList;



        }

        /// <summary>
        /// select single table with parameter
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static List<TEntity> GetView<TEntity>(string tableName , DataSourceType dataSource,SqlParameter[] sqlParameters = null) where TEntity : class, new()
        {


            TEntity model = new TEntity();
            List<TEntity> entityList = new List<TEntity>();
            Type modelType = model.GetType();
        
            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");
            foreach (var para in sqlParameters)
            {
                sql.Append($"  and {para.ParameterName.Replace("@", "")}='{para.Value}'");
            }

            PropertyInfo[] proInfo = modelType.GetProperties();


            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), sqlParameters, dataSource);
            while (sqlDataReader.Read())
            {
                #region 赋值给单一实体
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface)
                    {

                        //处理空值
                        if (sqlDataReader[propertyName] is DBNull)
                        {
                            item.SetValue(m, null, null);
                        }
                        else
                        {
                            item.SetValue(m, sqlDataReader[propertyName], null);
                        }
                    }

                }

                entityList.Add(m);



                #endregion

            }

            return entityList;



        }

    

        /// <summary>
        /// Get single row with parameters
        /// </summary>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static TEntity GetItemFromSingleTable<TEntity>(SqlParameter[] sqlParameters, DataSourceType dataSourceType) where TEntity : class, new()
        {
            TEntity model = new TEntity();

            Type modelType = model.GetType();
            string tableName = modelType.Name.Replace("Model", "");
            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");
            foreach (var para in sqlParameters)
            {
                sql.Append($"  and {para.ParameterName.Replace("@", "")}='{para.Value}'");
            }

            PropertyInfo[] proInfo = modelType.GetProperties();




            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(), sqlParameters, dataSourceType);

            while (sqlDataReader.Read())
            {
                //TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface &
                        !propertyName.EndsWith("Header") & !item.PropertyType.Name.EndsWith("Header") &
                        !propertyName.EndsWith("Archive") & !item.PropertyType.Name.EndsWith("Archive"))
                    {
                        //Sets the property value for a specified model.


                        //处理空值
                        if (sqlDataReader[propertyName] is DBNull)
                        {
                            item.SetValue(model, null, null);
                        }
                        else
                        {
                            item.SetValue(model, sqlDataReader[propertyName], null);
                        }
                       
                    }

                }


            }

            return model;

        }

        /// <summary>
        /// select data from physic table
        /// </summary>
        /// <param name="tableName">physic table except view</param>
        /// <param name="sqlParameters"></param>
        /// <param name="dataSourceType"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string tableName,SqlParameter[] sqlParameters,DataSourceType dataSourceType)
        {

            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");

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
                return Sqlhelper.GetDataTable(sql.ToString(), sqlParameters, dataSourceType);
            }






        }

        #endregion


        #region double table query

        /// <summary>
        /// 双表联接数据查询
        /// 档案+主表
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static DataTable GetDataList<TArchive, TMainWithArchive>(DataSourceType dataSourceType)
            where TArchive : class, new() where TMainWithArchive : class, new()
        {

            Type modelTypeArchive = new TArchive().GetType();
            Type modelTypeMain = new TMainWithArchive().GetType();


            string tableNameArchive = modelTypeArchive.Name.Replace("Model", "");
            string tableNameMain = modelTypeMain.Name.Replace("Model", "");



            #region get primary key and foreign key 

            PropertyInfo pkArchive = modelTypeArchive.GetProperties().Where
              (p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();

            PropertyInfo pkMain = modelTypeMain.GetProperties().Where
                (p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();

            var fkMain = modelTypeMain.GetProperties().Where
                (p => p.Name.ToLower().EndsWith("id"));


            #endregion

            #region build sql string

            StringBuilder sql = new StringBuilder($"select * from {tableNameArchive}  as a  ");
            foreach (var item in fkMain)
            {


                if (item.Name == pkArchive.Name)
                {

                    sql.Append($" inner join  {tableNameMain} as b  on   a.{pkArchive.Name}=b.{item.Name}");
                }

            }


            #endregion


            return Sqlhelper.GetDataTable(sql.ToString(), dataSourceType);



        }


        /// <summary>
        /// 双表联接数据查询
        /// 档案1+档案2+主表
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static DataTable GetDataList<TArchive1, TArchive2, TMainWithArchive>(DataSourceType dataSourceType)
            where TArchive1 : class, new() where TArchive2 : class, new() where TMainWithArchive : class, new()
        {


            Type modelTypeArchive1 = new TArchive1().GetType();
            Type modelTypeArchive2 = new TArchive2().GetType();
            Type modelTypeMain = new TMainWithArchive().GetType();


            string tableNameArchive1 = modelTypeArchive1.Name.Replace("Model", "");

            string tableNameArchive2 = modelTypeArchive2.Name.Replace("Model", "");
            string tableNameMain = modelTypeMain.Name.Replace("Model", "");




            #region get primary key and foreign key 

            PropertyInfo pkArchive1 = modelTypeArchive1.GetProperties().Where
              (p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();


            PropertyInfo pkArchive2 = modelTypeArchive2.GetProperties().Where
              (p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();

            PropertyInfo pkMain = modelTypeMain.GetProperties().Where
                (p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();

            var fkMain = modelTypeMain.GetProperties().Where
                (p => p.Name.ToLower().EndsWith("id"));

           
            


            #endregion

            #region build sql string

            StringBuilder sql = new StringBuilder($"select * from {tableNameMain}  as a   ");
            foreach (var item in fkMain)
            {


                if (item.Name == pkArchive1.Name)

                {
                    sql.Append($" inner join  {tableNameArchive1} as b  on   a.{item.Name}=b.{pkArchive1.Name}");

                }

                if (item.Name == pkArchive2.Name)
                {

                    sql.Append($" inner join  {tableNameArchive2} as c on   a.{item.Name}=c.{pkArchive2.Name}");


                }

            }


            #endregion


            return Sqlhelper.GetDataTable(sql.ToString(), dataSourceType);



        }



        #endregion


        /// <summary>
        /// triple table query
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static DataTable GetDataListAAM<TArchive, TMainWithArchive, TDetails>(DataSourceType dataSourceType)
            where TArchive : class, new() where TMainWithArchive : class, new() where TDetails : class, new()
        {
           

            Type modelTypeArchive = new TArchive().GetType();
            Type modelTypeMain = new TMainWithArchive().GetType();
            Type modelTypeDetails = new TDetails().GetType();

            string tableNameArchive = modelTypeArchive.Name.Replace("Model", "");
            string tableNameMain = modelTypeMain.Name.Replace("Model", "");
            string tableNameChilde = modelTypeDetails.Name.Replace("Model", "");
            StringBuilder sql = new StringBuilder($"select * from {tableNameArchive}  as a  ");


            #region get primary key and foreign key 

            PropertyInfo pkArchive = modelTypeArchive.GetProperties().Where
              (p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();
            PropertyInfo pkMain = modelTypeMain.GetProperties().Where
                (p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();

            //the foreignKeyAttribut exist in EF and .netFramwork 4.5 ,so erros throw 
            //var fkMain = modelTypeMain.GetProperties().Where
            //    (p => p.GetCustomAttributes(typeof(ForeignKeyAttribute), false).Length > 0);
            //var fkDetails = modelTypeDetails.GetProperties().
            //    Where(p => p.GetCustomAttributes(typeof(ForeignKeyAttribute), false).Length > 0);

            var fkMain = modelTypeMain.GetProperties().Where
             (p => p.Name.ToLower().EndsWith("id"));
            var fkDetails = modelTypeDetails.GetProperties().
                Where(p => p.Name.ToLower().EndsWith("id"));

            #endregion

            #region build sql string
            foreach (var item in fkMain)
            {

                if (item.Name == pkArchive.Name)
                {
                    sql.Append($" inner join  {tableNameMain} as b  on   a.{pkArchive.Name}=b.{item.Name}");
                }

            }

            foreach (var item in fkDetails)
            {

                if (item.Name == pkMain.Name)
                {
                    sql.Append($"  inner join  {tableNameChilde} as c  on   b.{pkMain.Name}=c.{item.Name}");
                }

            }
            #endregion

      
            return Sqlhelper.GetDataTable(sql.ToString(), dataSourceType);











        }


    }

}
