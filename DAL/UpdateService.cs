using System;
using System.Reflection;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using Utility.Sql;

namespace Utility.DAL
{
    public static class UpdateService
    {
        /// <summary>
        /// 单表单行修改
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TContext"></typeparam>
        /// <param name="expression"></param>
        /// <param name="entity"></param>
        public static void Update<TEntity, TContext>(Expression<Func<TEntity, bool>> expression, TEntity entity) where TEntity : class
                where TContext : DbContext, new()
        {

            try
            {
                using (var db = new TContext())
                {

                    TEntity dataOfDB = db.Set<TEntity>().Where(expression.Compile()).FirstOrDefault<TEntity>();

                    //data after change
                    var currentDataType = entity.GetType();

                    //data from database

                    var dataTypeOfDB = dataOfDB.GetType();

                    var prop = currentDataType.GetProperties();
                    var prop2 = dataTypeOfDB.GetProperties();

                    foreach (var cp in prop)
                    {
                        if (cp.GetValue(entity, null) != null)
                        {
                            foreach (var p2 in prop2)
                            {
                                //is it primaryKey?
                                if (p2.Name == cp.Name & cp.GetCustomAttributes(typeof(KeyAttribute), false).Length == 0)
                                {

                                    //set value to property
                                    p2.SetValue(dataOfDB, cp.GetValue(entity, null), null);
                                }
                            }
                        }
                    }

                    //dataOfDB = entity;


                    db.SaveChanges();


                    MessageBox.Show("数据修改成功");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }


        /// <summary>
        /// delete data first,then insert data
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="Context"></typeparam>
        /// <param name="listEntityes">data to be inserted</param>
        /// <param name="deleteFilter">filter to delete data </param>
        public static void Update<TEntity, Context>(List<TEntity> listEntityes, List<Expression<Func<TEntity, bool>>> deleteFilter = null) where TEntity : class
           where Context : DbContext, new()
        {

            using (var db = new Context())
            {
                using (var transction = db.Database.BeginTransaction())
                {

                    try
                    {
                        //delete data
                        if (deleteFilter != null)
                        {
                            foreach (var item in deleteFilter)
                            {
                                TEntity m = db.Set<TEntity>().Where(item.Compile()).FirstOrDefault();
                                db.Set<TEntity>().Remove(m);
                            }
                        }

                        #region insert data
                        db.Set<TEntity>().AddRange(listEntityes);


                        #endregion


                        db.SaveChanges();
                        transction.Commit();
                        MessageBox.Show("数据修改成功");
                    }
                    catch (Exception ex)
                    {

                        transction.Rollback();
                        MessageBox.Show(ex.Message + ex.InnerException);
                    }

                }












            }
        }


        public static void UpdateInBatche<TEntity, Context>(List<TEntity> listEntityes, List<Expression<Func<TEntity, bool>>> updateFilter, List<Expression<Func<TEntity, bool>>> deleteFilter = null) where TEntity : class
             where Context : DbContext, new()
        {

            using (var db = new Context())
            {
                using (var transction = db.Database.BeginTransaction())
                {

                    try
                    {
                        //delete data
                        if (deleteFilter != null)
                        {
                            foreach (var item in deleteFilter)
                            {
                                TEntity m = db.Set<TEntity>().Where(item.Compile()).FirstOrDefault();
                                db.Set<TEntity>().Remove(m);
                            }
                        }

                        #region 更新数据
                        if (updateFilter != null)
                        {
                            foreach (var item in updateFilter)
                            {

                                TEntity m = db.Set<TEntity>().Where(item.Compile()).FirstOrDefault<TEntity>();

                                var entity1 = listEntityes.Where(item.Compile()).GetType();

                                var entity2 = m.GetType();

                                var prop = entity1.GetProperties();
                                var prop2 = entity2.GetProperties();


                                foreach (var property in prop)
                                {
                                    if (property.GetValue(entity1, null) != null)
                                    {
                                        foreach (var item2 in prop2)
                                        {
                                            if (item2.Name == property.Name)
                                            {
                                                item2.SetValue(m, property.GetValue(entity1, null), null);
                                            }
                                        }
                                    }
                                }
                                //m = entity1;
                            }
                        }
                        #endregion


                        db.SaveChanges();
                        transction.Commit();
                        MessageBox.Show("数据修改成功");
                    }
                    catch (Exception ex)
                    {

                        transction.Rollback();
                        MessageBox.Show(ex.Message + ex.InnerException);
                    }

                }












            }
        }

        /// <summary>
        /// update one field
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="filed"></param>
        /// <param name="value"></param>
        /// <param name="filterFild"></param>
        /// <param name="sqlparameters"></param>
        public static void Update<TEntity>(TEntity entity, string filed , object value, string filterFild, SqlParameter[] sqlparameters) where TEntity : class
              , new()
        {

            try
            {
               
                    
                    string tableName = entity.GetType().Name;
                    string sql = $"update {tableName} set { filed} ={value} where {filterFild}=@{filterFild} ";
                Sqlhelper.UpdateWithparameters(sql, Sqlhelper.DataSourceType.business, sqlparameters);

                    //data after change
                 


                    MessageBox.Show("数据修改成功");

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }
    }





}
