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



namespace Utility.UI
{
    public partial class Frm_config : Form
    {

        public Frm_config()
        {
            InitializeComponent();
            this.button_confirm.Enabled = false;
        }

        private void Frm_config_Load(object sender, EventArgs e)
        {
            this.readDataBase();
        }

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

                    this.button_confirm.Enabled = true;
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
        /// 默认读取数据库连接信息中的数据库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// 读取数据库连接信息中的数据库信息
        /// </summary>

        private void readDataBase()
        {
            string conectDataBase = "myConcetion";

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
        }

        /// <summary>
        /// 删除数据库配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_deleteConfig_Click(object sender, EventArgs e)
        {
            if (this.lbl_status.Text != "未配置")
            {
                string conectionInformation = "myConcetion";

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

        /// <summary>
        /// 关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_config_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void toolStripButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 删除数据库配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_deleteDateConfig_Click(object sender, EventArgs e)
        {

            if (this.lbl_status.Text != "未配置")
            {
                string conectionInformation = "myConcetion";

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.Remove(conectionInformation);
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("数据库配置删除成功", "删除提示");
                ConfigurationManager.RefreshSection("connectionStrings");
                this.lbl_status.Text = "未配置";
                this.lbl_status.ForeColor = Color.Red;



            }
            else
            {
                MessageBox.Show("没有可删除的数据库连接", "删除提示");
            }

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 新增或更改数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_confirm_Click(object sender, EventArgs e)
        {
            bool isModified = false;    //记录该连接串是否已经存在

            string provider = "System.Data.SqlClient;";
            string conString = "Data Source=" + textBox_server.Text + ";Initial Catalog=" + textBox_database.Text + ";" +
                "User ID=" + textBox_user.Text + ";Password="
                + textBox_password.Text + ";Pooling=False;";
            //加密码连接字符串
            string encryptConString = Utility.Encrypt.Encode(conString);


            if (ConfigurationManager.ConnectionStrings["myConcetion"] != null)
            {
                isModified = true;
            }
            //新建一个连接字符串实例,三个参数的构造函数可以兼容EF的连接字符串
            //因为EF可以连接多种数据库，所以必须提供providerName

            ConnectionStringSettings mySettings = new ConnectionStringSettings("myConcetion", encryptConString, provider);

            // 打开可执行的配置文件*.exe.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 如果连接串已存在，首先删除它 
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove("myConcetion");
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
    }

}
