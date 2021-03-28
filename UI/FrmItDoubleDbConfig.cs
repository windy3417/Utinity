using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static Utility.Sql.Sqlhelper;

namespace Utility.UI
{
    public partial class FrmItDoubleDbConfig : Form
    {

        public FrmItDoubleDbConfig()
        {
            InitializeComponent();
         
        }

        #region 初始化控件

        private void Frm_DoubleDataBaseConfig_Load(object sender, EventArgs e)
        {
            this.btn_confirm.Enabled = false;
            btn_plugCertain.Enabled = false;
            this.readDataBase();
        }

    
        #endregion

        #region 事件处理
        /// <summary>
        /// 键盘按键事件
        /// 如果检查到按下的是回车键，则发一个消息，模拟键盘按以下Tab键，
        /// 以使输入焦点转移到下一个文本框（或其他焦点可停留的控件）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        #endregion

        #region Btn事件处理


        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_testConect_Click(object sender, EventArgs e)
        {


            //获取数据库连接字符串
            string con = "Data Source=" + textBox_server.Text + ";Initial Catalog=" + textBox_database.Text + ";User ID= " + textBox_user.Text + ";Password=" +
                textBox_password.Text + ";Pooling=False";

            //创建连接对象
            SqlConnection mySqlConnection = new SqlConnection(con);
            try
            {
                mySqlConnection.Open();
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("连接成功！", "连接提示");

                    this.btn_confirm.Enabled = true;
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

        #region 运维数据库配置

        /// <summary>
        /// 新增或更改数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_confirm_Click(object sender, EventArgs e)
        {
            bool conectionStringExist = false;    //记录该连接串是否已经存在

            string provider = "System.Data.SqlClient;";
            string conString = "Data Source=" + textBox_server.Text + ";Initial Catalog=" + textBox_database.Text + ";" +
                "User ID=" + textBox_user.Text + ";Password="
                + textBox_password.Text + ";Pooling=False;";
            //加密码连接字符串
            string encryptConString = Utility.Encrypt.Encode(conString);


            if (ConfigurationManager.ConnectionStrings[DataSourceType.u8.ToString()] != null)
            {
                conectionStringExist = true;
            }
            //新建一个连接字符串实例,三个参数的构造函数可以兼容EF的连接字符串
            //因为EF可以连接多种数据库，所以必须提供providerName

            ConnectionStringSettings mySettings = new ConnectionStringSettings(DataSourceType.u8.ToString(), encryptConString, provider);

            // 打开可执行的配置文件*.exe.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 如果连接串已存在，首先删除它 
            if (conectionStringExist)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(DataSourceType.u8.ToString());
            }
            // 将新的连接串添加到配置文件中. 
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改 
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节  
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("数据库配置成功", "数据库配置");
            this.lbl_status.Text = "已经配置";
            this.lbl_status.ForeColor = Color.Green;

        }

        /// <summary>
        /// 删除数据库配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_deleteItConfig_Click(object sender, EventArgs e)
        {
            if (this.lbl_status.Text != "未配置")
            {
                string conectionInformation = "itConcetion";

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.Remove(conectionInformation);
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("数据库配置删除成功", "删除提示");
                ConfigurationManager.RefreshSection("connectionStrings");
                this.lbl_status.Text = "未配置";
                this.lbl_status.ForeColor = Color.Red;
                //刷新主窗体状态栏



            }
            else
            {
                MessageBox.Show("没有可删除的数据库连接", "删除提示");
            }
        }
        #endregion


        #region 业务数据库配置
        
        /// <summary>
        /// 删除业务数据库配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deletePlugConfig_Click(object sender, EventArgs e)
        {
            if (lbl_plugStatus.Text != "未配置")
            {
                string conectionInformation = "businessConection";

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.Remove(conectionInformation);
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("数据库配置删除成功", "删除提示");
                ConfigurationManager.RefreshSection("connectionStrings");
                lbl_plugStatus.Text = "未配置";
                lbl_plugStatus.ForeColor = Color.Red;



            }
            else
            {
                MessageBox.Show("没有可删除的数据库连接", "删除提示");
            }

        }

        /// <summary>
        /// 新增或更改业务数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveBusinessConnetiongString_Click(object sender, EventArgs e)
        {
            bool isModified = false;    //记录该连接串是否已经存在

            string provider = "System.Data.SqlClient;";
            string conString = "Data Source=" + txt_plugServer.Text + ";Initial Catalog=" + txt_plugDataBase.Text + ";" +
                "User ID=" + txt_plugUser.Text + ";Password="
                + txt_plugPWD.Text + ";Pooling=False;";
            //加密码连接字符串
            string encryptConString = Utility.Encrypt.Encode(conString);


            if (ConfigurationManager.ConnectionStrings[DataSourceType.business.ToString()] != null)
            {
                isModified = true;
            }
            //新建一个连接字符串实例,三个参数的构造函数可以兼容EF的连接字符串
            //因为EF可以连接多种数据库，所以必须提供providerName

            ConnectionStringSettings mySettings = new ConnectionStringSettings(DataSourceType.business.ToString(), encryptConString, provider);

            // 打开可执行的配置文件*.exe.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 如果连接串已存在，首先删除它 
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(DataSourceType.business.ToString());
            }
            // 将新的连接串添加到配置文件中. 
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改 
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节  
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("数据库配置成功", "数据库配置");
            lbl_plugStatus.Text = "已经配置";
            lbl_plugStatus.ForeColor = Color.Green;
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_plugConcet_Click(object sender, EventArgs e)
        {
            //获取数据库连接字符串
            string con = "Data Source=" + txt_plugServer.Text + ";Initial Catalog=" + txt_plugDataBase.Text + ";User ID= " + txt_plugUser.Text + ";Password=" +
                txt_plugPWD.Text + ";Pooling=False";

            //创建连接对象
            SqlConnection mySqlConnection = new SqlConnection(con);
            try
            {
                mySqlConnection.Open();
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("连接成功！", "连接提示");

                    btn_plugCertain.Enabled = true;
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

        #endregion

        #endregion


        #region 内部方法
        /// <summary>
        /// 读取控件数据源
        /// </summary>
        private void readDataBase()
        {
            string conectDataBase = "it";
            string conectPlugDataBase = "business";

            if (ConfigurationManager.ConnectionStrings[conectDataBase] != null)
            {
                string conString = ConfigurationManager.ConnectionStrings[conectDataBase].ToString();
                string deConString = Encrypt.Decode(conString);
                int dataBaseIndex = deConString.IndexOf("Catalog=");
                int UserIndex = deConString.IndexOf(";User");

                this.lbl_status.Text = deConString.Substring(dataBaseIndex + 8, UserIndex - (dataBaseIndex + 8));
                this.lbl_status.ForeColor = Color.Green;

            }
            else
            {
                this.lbl_status.Text = "未配置";
                this.lbl_status.ForeColor = Color.Red; ;
            }

            if (ConfigurationManager.ConnectionStrings[conectPlugDataBase] != null)
            {
                string conString = ConfigurationManager.ConnectionStrings[conectPlugDataBase].ToString();
                string deConString = Encrypt.Decode(conString);
                int dataBaseIndex = deConString.IndexOf("Catalog=");
                int UserIndex = deConString.IndexOf(";User");

                this.lbl_plugStatus.Text = deConString.Substring(dataBaseIndex + 8, UserIndex - (dataBaseIndex + 8));
                this.lbl_plugStatus.ForeColor = Color.Green;

            }
            else
            {
                this.lbl_plugStatus.Text = "未配置";
                this.lbl_plugStatus.ForeColor = Color.Red; ;
            }
        }

        #endregion

      

        #region 窗体操作

        /// <summary>
        /// 关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_config_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }

}
