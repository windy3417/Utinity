using System;
using System.Reflection;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Utility.DAL
{
   public  class UpdateService
    {
        /// <summary>
        /// 单表修改
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TContext"></typeparam>
        /// <param name="expression"></param>
        /// <param name="entity"></param>
        public void Upadate<TEntity,TContext>(Expression<Func<TEntity, bool>> expression, TEntity entity) where TEntity : class 
                where TContext : DbContext, new ()
        {

            try
            {
                using (var db = new TContext())
                {

                    TEntity m = db.Set<TEntity>().Where(expression.Compile()).FirstOrDefault<TEntity>();

                    var entity1 = entity.GetType();
                    var entity2 = m.GetType();

                    var prop = entity1.GetProperties();
                    var prop2 = entity2.GetProperties();

                    foreach (var item in prop)
                    {
                        if (item.GetValue(entity,null) != null)
                        {
                            foreach (var item2 in prop2)
                            {
                                if (item2.Name == item.Name)
                                {
                                    item2.SetValue(m, item.GetValue(entity,null),null);
                                }
                            }
                        }
                    }

                    m = entity;


                    db.SaveChanges();

                    MessageBox.Show("数据修改成功");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }


        public void UpdateInBatche<TEntity, Context>(List<TEntity> listEntityes,List<Expression<Func<TEntity, bool>>> updateFilter,List<Expression<Func<TEntity, bool>>>  deleteFilter=null) where TEntity : class
             where Context : DbContext, new()
        {
            try
            {
                using (var db = new Context())
                {
                    using (var transction=db.Database.BeginTransaction())
                    {

                        if (deleteFilter!=null)
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
                    }
                   

                        


                       
                        db.SaveChanges();

                        MessageBox.Show("数据修改成功");

                       
                    
                  


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }


    }


}
