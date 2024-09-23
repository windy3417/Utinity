using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.Model;
using Utility.Files;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Utility.DAL
{
 public   class ConnectString
    {
        #region DB connection string handle

        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <param name="m">连接字符串实体</param>
        public void DbConnectTest(ConnectStringModel m)
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


        public void ReadConfig(string fileName, Label status)
        {

            //读取数据库配置
            if (File.Exists(fileName))
            {

                JsonOperate jsonOperate = new JsonOperate();
                ConnectStringModel m = new ConnectStringModel();

                ConnectStringModel connectModel = jsonOperate.JsonToModel<ConnectStringModel>(fileName, m);

                status.Text = connectModel.DataSource + "-" + connectModel.DataBase;

                status.ForeColor = Color.Green;

            }
            else
            {
                status.Text = "未配置";
                status.ForeColor = Color.Red;
            }






        }
        #endregion


        #region SMB connection string handle

        /// <summary>
        /// 保存SMB连接字符串
        /// </summary>
        /// <param name="m">连接字符串实体</param>
        /// <param name="connectKey">配置文件中的数据库连接字符串键</param>
        public void PutSmbConnectionString(ConnectStringModel m,string directory)
        {
         
                      
            //加密码连接字符串
            m.DataSource = Utility.Encrypt.Encode(m.DataSource);
            m.DataBase = Utility.Encrypt.Encode(m.DataBase);
            m.FileDirectory = Utility.Encrypt.Encode(m.FileDirectory);
            m.UserName= Utility.Encrypt.Encode(m.UserName);
            m.Pwd = Utility.Encrypt.Encode(m.Pwd);

         

            using (FileStream s = File.Create(directory)) 
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, m);
            }
          
                      

            MessageBox.Show("配置成功", "连接配置");


        }

        public  ConnectStringModel GetSmbConnectionString(string directory)
        {



            try
            {
                ConnectStringModel m = new ConnectStringModel();

                using (FileStream s = File.OpenRead(directory))
                {
                    IFormatter formatter = new BinaryFormatter();
                    m = (ConnectStringModel)formatter.Deserialize(s);
                }



                //加密码连接字符串
                m.DataSource = Utility.Encrypt.Decode(m.DataSource);
                m.DataBase = Utility.Encrypt.Decode(m.DataBase);
                m.FileDirectory = Encrypt.Decode(m.FileDirectory);
                m.UserName = Utility.Encrypt.Decode(m.UserName);
                m.Pwd = Utility.Encrypt.Decode(m.Pwd);

                return m;
            }
            catch (Exception ex )
            {

                return null;
            }  

           


        }



        #endregion


    }
}
