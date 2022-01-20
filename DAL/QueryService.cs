﻿using System;
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
        /// <summary>
        /// 单表全数化查询
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


            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(),  dataSource);
            while (sqlDataReader.Read())
            {
                #region 赋值给单一实体
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface)
                    {
                        item.SetValue(m, sqlDataReader[propertyName], null);
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
        public static List<TEntity> GetDataList<TEntity>(SqlParameter[] sqlParameters, DataSourceType dataSource) where TEntity : class, new()
        {
            TEntity model = new TEntity();
            List<TEntity> entityList = new List<TEntity>();
            Type modelType = model.GetType();
            string tableName = modelType.Name.Replace("Model","");
            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");
            foreach (var para in sqlParameters)
            {
                sql.Append($"  and {para.ParameterName.Replace("@", "")}={para.ParameterName}");
            }

            PropertyInfo[] proInfo = modelType.GetProperties();


            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(),sqlParameters, dataSource);
            while (sqlDataReader.Read())
            {
                #region 赋值给单一实体
                TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface)
                    {
                        item.SetValue(m, sqlDataReader[propertyName], null);
                    }
                   
                }

                entityList.Add(m);



                #endregion

            }

            return entityList;



        }

        /// <summary>
        /// 单表单行参数化查询
        /// </summary>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static TEntity GetEntity<TEntity>(SqlParameter[] sqlParameters,DataSourceType dataSourceType) where TEntity : class, new()
        {
            TEntity model = new TEntity();

            Type modelType = model.GetType();
            string tableName = modelType.Name.Replace("Model", "");
            StringBuilder sql = new StringBuilder($"select * from {tableName} where 1=1");
            foreach (var para in sqlParameters)
            {
                sql.Append($"  and {para.ParameterName.Replace("@", "")}={para.ParameterName}");
            }

            PropertyInfo[] proInfo = modelType.GetProperties();

                     
          

            SqlDataReader sqlDataReader = Sqlhelper.GetSqlDataReader(sql.ToString(),sqlParameters, dataSourceType);

            while (sqlDataReader.Read())
            {
                //TEntity m = new TEntity();
                foreach (var item in proInfo)
                {
                    var propertyName = item.Name;
                    if (!propertyName.EndsWith("Model") & !item.PropertyType.Name.EndsWith("Model") & !item.PropertyType.IsInterface )
                    {
                        item.SetValue(model, sqlDataReader[propertyName], null);
                    }
                    
                }


            }

            return model;

        }

        /// <summary>
        /// 双表联接数据查询
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
                (p => p.GetCustomAttributes(typeof(ForeignKeyAttribute), false).Length > 0);


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
        /// 三表联接数据查询
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static DataTable GetDataList<TArchive, TMainWithArchive, TDetails>(DataSourceType dataSourceType)
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
            var fkMain = modelTypeMain.GetProperties().Where
                (p => p.GetCustomAttributes(typeof(ForeignKeyAttribute), false).Length > 0);
            var fkDetails = modelTypeDetails.GetProperties().
                Where(p => p.GetCustomAttributes(typeof(ForeignKeyAttribute), false).Length > 0);

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