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
using Utility.Model;
using static Utility.Sql.Sqlhelper;

namespace Utility.UI
{
    public partial class FrmLoginConfigDB : Form
    {


        public FrmLoginConfigDB()

        {
            InitializeComponent();
            initializeControlState();


        }

        #region 变量

        bool isExist = false;    //记录数据库连接串是否已经存在
        #endregion

        /// <summary>
        /// 初始化控件状态
        /// </summary>
        void initializeControlState()
        {

            btnBusinessSave.Enabled = false;
            txt_adminCode.Enabled = false;
            txt_adminName.Enabled = false;
            gb_admin.Visible = false;
            plugConfigSuccess += displayAdminForm;
        }



        #region 自定义事件

        event EventHandler plugConfigSuccess;

        void onPlugConfigSuccess(EventArgs e)
        {
            plugConfigSuccess?.Invoke(this, e);
        }

        void displayAdminForm(object sender, EventArgs e)
        {
            gb_admin.Visible = true;
        }



        #endregion


        #region 事件处理

        private void Frm_DoubleDataBaseConfig_Load(object sender, EventArgs e)
        {
            this.readDataBase();
        }


        #endregion


        /// <summary>
        /// 鼠标按键事件。
        /// 如果检查到按下的是回车键，则发一个消息，模拟键盘按以下Tab键，以使输入焦点转移到下一个文本框（或其他焦点可停留的控件）
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



        /// <summary>
        /// 默认读取数据库连接信息中的数据库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// 读取数据库连接信息中的数据库信息
        /// </summary>

        private void readDataBase()
        {
            string conectDataBase = "myConection";
            string conectPlugDataBase = "plugConection";

            if (ConfigurationManager.ConnectionStrings[conectDataBase] != null)
            {
                string conString = ConfigurationManager.ConnectionStrings[conectDataBase].ToString();
                string deConString = Encrypt.Decode(conString);
                int dataBaseIndex = deConString.IndexOf("Catalog=");
                int UserIndex = deConString.IndexOf(";User");



            }
            else
            {

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



        #region 数据库配置


        /// <summary>
        /// 删除外挂数据库配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deletePlugConfig_Click(object sender, EventArgs e)
        {
            if (lbl_plugStatus.Text != "未配置")
            {
                string conectionInformation =DataSourceType.plug.ToString();

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
        /// 保存外挂数据库连接字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlugStringSave_Click(object sender, EventArgs e)
        {
                       
            string conString = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDB.Text + ";" +
                 "User ID=" + txtUser.Text + ";Password="
                 + txtPwd.Text + ";Pooling=False;";
            //加密码连接字符串
            saveConnectString(conString,DataSourceType.plug);
        }

        /// <summary>
        /// 保存业务数据库连接字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBusinessSave_Click(object sender, EventArgs e)
        {

            string conString = "Data Source=" + txt_plugServer.Text + ";Initial Catalog=" + txt_plugDataBase.Text + ";" +
             "User ID=" + txt_plugUser.Text + ";Password="
             + txt_plugPWD.Text + ";Pooling=False;";

            //保存连接字符串
            saveConnectString(conString, DataSourceType.business);

            //业务数据库配置成功，则引发事件
            onPlugConfigSuccess(EventArgs.Empty);
            lbl_plugStatus.Text = "已经配置";
            lbl_plugStatus.ForeColor = Color.Green;
        }

        /// <summary>
        /// 外挂数据库测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_plugConcet_Click(object sender, EventArgs e)
        {
            //获取数据库连接字符串
            string con = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDB.Text + ";" +
                "User ID= " + txtUser.Text + ";Password=" +
                txtPwd.Text + ";Pooling=False";

            sqlConnectTest(con);
        }

        /// <summary>
        /// 业务数据库连接测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnectTest_Click(object sender, EventArgs e)
        {
            //获取数据库连接字符串
            string con = "Data Source=" + txt_plugServer.Text + ";Initial Catalog=" + txt_plugDataBase.Text + ";" +
                "User ID= " + txt_plugUser.Text + ";Password=" +
                txt_plugPWD.Text + ";Pooling=False";

            sqlConnectTest(con);
        }

        #region 内部方法


        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <param name="con"></param>
        private void sqlConnectTest(string con)
        {
            //创建连接对象
            SqlConnection mySqlConnection = new SqlConnection(con);
            try
            {
                mySqlConnection.Open();
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("连接成功！", "连接提示");

                    btnBusinessSave.Enabled = true;
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
        /// <param name="isModified"></param>
        /// <param name="conString"></param>
        /// <returns></returns>
        private void saveConnectString(string conString, DataSourceType dataSourceType)
        {
            string encryptConString = Utility.Encrypt.Encode(conString);
            string provider = "System.Data.SqlClient;";


            // 打开可执行的配置文件*.exe.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 如果连接串已存在，首先删除它 
            if (ConfigurationManager.ConnectionStrings[dataSourceType.ToString()] != null)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(dataSourceType.ToString());
            }
            //新建一个连接字符串实例,三个参数的构造函数可以兼容EF的连接字符串
            //因为EF可以连接多种数据库，所以必须提供providerName

            ConnectionStringSettings mySettings = new ConnectionStringSettings(dataSourceType.ToString(), encryptConString, provider);

          
            // 将新的连接串添加到配置文件中. 
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改 
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节  
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("数据库配置成功", "数据库配置");

          
          
        }
        #endregion


        #endregion


        /// <summary>
        /// 写入管理员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_adminCertain_Click(object sender, EventArgs e)
        {
            CurrentUser.userID = txt_adminCode.Text;
            CurrentUser.userName = txt_adminName.Text;
            CurrentUser.pwd = txt_adminPwd.Text;
            MessageBox.Show("管理员信息设置成功");
        }

    }

}
