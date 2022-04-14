using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.DAL
{
  public  class SaveService
    {
        /// <summary>
        /// 单表单行保存
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void SaveSingleDate<TEntity, Context>(TEntity entity) where TEntity : class where Context : DbContext, new()
        {

            try
            {
                using (var db = new Context())
                {


                    db.Set<TEntity>().Add(entity);

                    db.SaveChanges();

                    MessageBox.Show("数据保存成功");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }


        /// <summary>
        /// 单表多行保存
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="Context"></typeparam>
        /// <param name="entityList"></param>
        public bool SaveRows<TEntity, Context>(List<TEntity> entityList) where TEntity : class where Context : DbContext, new()
        {

            try
            {
                using (var db = new Context())
                {

                    db.Set<TEntity>().AddRange(entityList);

                    db.SaveChanges();

                    MessageBox.Show("数据保存成功");
                    return true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
                return false;
            }
        }


        /// <summary>
        /// 数据保存事务,双表单行
        /// </summary>
        /// <typeparam name="TEntity1"></typeparam>
        /// <typeparam name="TEntity2"></typeparam>
        /// <param name="entity1"></param>
        /// <param name="entity2"></param>
        public void SaveDate<TEntity1, TEntity2,Context>(TEntity1 entity1, TEntity2 entity2) where TEntity1 : class where TEntity2 : class
                        where Context : DbContext, new ()
        {

            try
            {
                using (var db = new Context())
                {

                    using (var trasction = db.Database.BeginTransaction())
                    {
                        db.Set<TEntity1>().Add(entity1);
                        db.Set<TEntity2>().Add(entity2);

                        db.SaveChanges();

                        trasction.Commit();

                    }


                    MessageBox.Show("数据保存成功");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        /// <summary>
        /// 主子表数据保存事务
        /// </summary>
        /// <typeparam name="TEntity1">main</typeparam>
        /// <typeparam name="TEntiry2">ditails</typeparam>
        /// <param name="entityMain"></param>
        /// <param name="entityDetail"></param>
        public void Save<TEntity1, TEntiry2, Context>(TEntity1 entityMain, List<TEntiry2> entityDetail) where TEntity1 : class where TEntiry2 : class
            where Context : DbContext, new()
        {

            try
            {
                using (var db = new Context())
                {

                    using (var trasction = db.Database.BeginTransaction())
                    {
                        db.Set<TEntity1>().Add(entityMain);
                        db.Set<TEntiry2>().AddRange(entityDetail);

                        db.SaveChanges();

                        trasction.Commit();

                    }


                    MessageBox.Show("数据保存成功");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        /// <summary>
        /// 数据导入，批量保存主子表事务
        /// </summary>
        /// <typeparam name="TEntity1"></typeparam>
        /// <typeparam name="TEntiry2"></typeparam>
        /// <param name="entityMain"></param>
        /// <param name="entityDetail"></param>
        public void SaveBatch<TEntity1, TEntiry2,Context>(List<TEntity1> entityMain, List<TEntiry2> entityDetail) where TEntity1 : class where TEntiry2 : class
            where Context :DbContext ,new ()
        {

            try
            {
                using (var db = new Context())
                {

                    using (var trasction = db.Database.BeginTransaction())
                    {
                        db.Set<TEntity1>().AddRange(entityMain);
                        db.Set<TEntiry2>().AddRange(entityDetail);

                        db.SaveChanges();

                        trasction.Commit();

                    }


                    MessageBox.Show("数据保存成功");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }
    }
}
