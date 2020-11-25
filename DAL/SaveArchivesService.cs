using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.DAL
{
    public class SaveArchivesService
    {
        public void save(DbContext dbContext, Type users, object Modle, Dictionary<dynamic,dynamic> propertyValue)
        {

            //新增后保存

            using (dbContext)
            {
                Type proper = Modle.GetType();
                System.Reflection.PropertyInfo[] ps = proper.GetProperties();
                foreach (var item in ps)
                {
                    //if (item.Name==propertyValue.k)
                    {

                    }
                }

                //Modle.userID = txt_cusCode.Text;
                //Modle.name = this.txt_cusName.Text;
                //Modle.pwd = Encrypt.Encode(txt_pwd.Text);
                //Modle.RegistrationDate = Convert.ToDateTime(this.tbd_effect.Text);
                //if (this.tbd_failure.Text != null & tbd_failure.Text != "")
                //{
                //    Modle.DateOfCancellation = Convert.ToDateTime(this.tbd_failure.Text);
                //}


                dbContext.Set(users).Add(Modle);
                try
                {
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {

                    MessageBox.Show("数据保存错误:" + e.Message + e.InnerException, "数据保存提示");
                    return;
                }

               

            }
        }


    }
}