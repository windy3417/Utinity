using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.Model;

namespace Utility.DAL
{
 public   class DbConnect
    {
        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <param name="m">连接字符串实体</param>
        public void DbConnectTest(ConnectStringModel  m)
        {
            //获取数据库连接字符串
            string con = "Data Source=" + m.DataSource + ";Initial Catalog=" + m.DataBase
                + ";User ID= " + m.UserName + ";Password=" +
                m.Pwd + ";Pooling=False";

            //创建连接对象
            SqlConnection mySqlConnection = new SqlConnection(con);
            try
            {
                mySqlConnection.Open();
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("连接成功！", "连接提示");
                                       
                }
                else
                {
                    MessageBox.Show("连接失败！", "连接提示");
                }
            }
            catch
            {
                MessageBox.Show("连接失败！", "连接提示");
            }
            finally
            {
                mySqlConnection.Close();
            }


        }

        /// <summary>
        /// 保存数据库连接字符串
        /// </summary>
        /// <param name="m">连接字符串实体</param>
        /// <param name="connectKey">配置文件中的数据库连接字符串键</param>
        public void DbConnectStringSave(ConnectStringModel m, string connectKey)
        {
            bool conectionStringExist = false;    //记录该连接串是否已经存在

            string provider = "System.Data.SqlClient;";
            string conString = "Data Source=" + m.DataSource + ";Initial Catalog=" + m.DataBase + ";" +
                "User ID=" + m.UserName + ";Password="
                + m.Pwd + ";Pooling=False;";
            //加密码连接字符串
            string encryptConString = Utility.Encrypt.Encode(conString);


            if (ConfigurationManager.ConnectionStrings[connectKey] != null)
            {
                conectionStringExist = true;
            }
            //新建一个连接字符串实例,三个参数的构造函数可以兼容EF的连接字符串
            //因为EF可以连接多种数据库，所以必须提供providerName

            ConnectionStringSettings mySettings = new ConnectionStringSettings(connectKey, encryptConString, provider);

            // 打开可执行的配置文件*.exe.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 如果连接串已存在，首先删除它 
            if (conectionStringExist)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(connectKey);
            }
            // 将新的连接串添加到配置文件中. 
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改 
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节  
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("数据库配置成功", "数据库配置");
           
           
        }
    }
}
