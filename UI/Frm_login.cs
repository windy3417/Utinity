using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Utility;
using System.Configuration;
using Utility.Modle;

namespace Utility.UI
{
    /// <summary>
    /// 重注册时要调用该窗体，故设定访问域为public
    /// </summary>
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
            intializeControlState();
            initializeDatasource();
        }

        #region 变量

        bool loginSuccessFlag;
        #endregion

        #region 初始化

        void intializeControlState()
        {
            lbl_information.Visible = false;
            
            checkDatabaseConect();
            txt_userID.Focus();
            //txt_userID.TabIndex = 0;
        }

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        private void initializeDatasource()
        {

        }

        #endregion



        #region 事件

       
            
      
        /// <summary>
        /// 登录确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_certain_Click(object sender, EventArgs e)
        {
           
            if (inputVlidate())
            {
                //登录系统
                if (ch_changePWD.Checked == false)
                {
                    string pwd = Encrypt.Encode(txt_pwd.Text);

                    if (checkPwd(txt_userID.Text,pwd))
                    {
                        //记录登录信息
                        CurrentUser.userID = txt_userID.Text;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {

                        lbl_information.Text = "";
                        lbl_information.Text = lbl_information.Text + "您输入的用户名或密码不正确，请重新输入";
                        lbl_information.Visible = true;
                        txt_pwd.Focus();

                    }
                }
                //登录系统并修改密码
                else
                {

                    string pwd = Encrypt.Encode(txt_pwd.Text);
                    changePWD(pwd);

                }

            }
            ;


        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        protected virtual bool changePWD(string pwd)
        {
            return false;
        }


        /// <summary>
        /// 检测用户名密码是否正确
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        protected virtual bool checkPwd(string user,string pwd)
        {

            return false;

            
        }

     

        /// <summary>
        /// //主窗体点击重登录时，调出登录窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 重登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowDialog();
            //this.Activate();
        }


        /// <summary>
        /// 登录前数据库连接设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_conect_Click(object sender, EventArgs e)
        {
            Utility.UI.Frm_loginConfig f = new Utility.UI.Frm_loginConfig();
            f.btn_adminCertain.Click += adminSetup;
            
            //以模式窗体显示
            f.ShowDialog();
        }

        #endregion

        #region 窗体操作

        /// <summary>
        /// 子窗体关闭后，联动关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeLoginForm(object sender, FormClosedEventArgs e)
        {
            if (loginSuccessFlag)
            {
                this.Hide();
            }
            else
            {
                this.Close();
            }
           
        }


        /// <summary>
        /// 回车代替TAB键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
            }
        }
        #endregion


        /// <summary>
        /// 检测数据库是否连接
        /// </summary>
        void checkDatabaseConect()
        {
            if (ConfigurationManager.ConnectionStrings["plugConection"] != null & ConfigurationManager.ConnectionStrings["myConection"] != null)
            {
                btn_conect.Visible = false;
            }
        }

        /// <summary>
        /// 非空校验
        /// </summary>
        /// <returns></returns>
        private bool inputVlidate()
        {

            for (int i = 0; i < this.p_login.Controls.Count;)
            {

                if (this.p_login.Controls[i].Text == "" || this.p_login.Controls[i].Text == null)
                {
                    MessageBox.Show(this.p_login.Controls[i].Tag + "不能为空", "输入校验");
                    return false;
                }


                i++;


            }
            return true;


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (loginSuccessFlag)
            {
                this.Hide();
                //this.DialogResult
            }
            else
            {
                this.Close();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /// <summary>
        /// 生成管理员账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        protected virtual void adminSetup(object sender,EventArgs eventArgs)
        {

        }
    }






}
