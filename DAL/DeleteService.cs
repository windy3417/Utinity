using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Utility.DAL
{
  public  static class DeleteService
    {
        /// <summary>
        /// delete single row data
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="expression">conditon for del</param>
        public static void DeletSingleRow<TEntity, Context>(DataGridView dataGridView, Expression<Func<TEntity, bool>> expression) where TEntity : class 
          where  Context : DbContext, new()
        {
            try
            {
                using (var db = new Context())
                {

                    if (dataGridView.CurrentRow != null)
                    {

                        TEntity m = db.Set<TEntity>().Where(expression.Compile()).FirstOrDefault();


                        db.Set<TEntity>().Remove(m);
                        db.SaveChanges();

                        MessageBox.Show("数据删除成功");

                        dataGridView.DataSource = db.Set<TEntity>().ToList();
                    }
                    else
                    {
                        MessageBox.Show("请选择要删除的行");
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        public static void DeleteCascaded<TEntity, Context>(Expression<Func<TEntity, bool>> expression) where TEntity : class
    where Context : DbContext, new()
        {
            try
            {
                using (var db = new Context())
                {
                                      
                        TEntity m = db.Set<TEntity>().Where(expression.Compile()).FirstOrDefault();


                        db.Set<TEntity>().Remove(m);
                        db.SaveChanges();

                        MessageBox.Show("数据删除成功");

                     
                   


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }



        /// <summary>
        /// 主子表数据删除事务
        /// </summary>
        /// <typeparam name="TEntityMain"></typeparam>
        /// <typeparam name="TEntityDetail"></typeparam>
        /// <param name="exp1"></param>
        /// <param name="exp2"></param>
        public static void DeleteHeaderDetails<TEntityMain, TEntityDetail,Context>(Expression<Func<TEntityMain, bool>> exp1, 
            Expression<Func<TEntityDetail, bool>> exp2) where TEntityMain : class
            where TEntityDetail : class where Context :DbContext ,new ()
        {

            try
            {
                using (var db = new Context())
                {

                    using (var trasction = db.Database.BeginTransaction())
                    {
                        List<TEntityDetail> mList = db.Set<TEntityDetail>().Where(exp2.Compile()).ToList();
                        TEntityMain d = db.Set<TEntityMain>().Where(exp1.Compile()).FirstOrDefault();
                        db.Set<TEntityDetail>().RemoveRange(mList);
                        db.Set<TEntityMain>().Remove(d);


                        db.SaveChanges();

                        trasction.Commit();

                    }


                    MessageBox.Show("数据删除成功");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }
    }
}
