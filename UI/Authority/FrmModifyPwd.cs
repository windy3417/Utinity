using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Utility;
using Utility.DAL.Services;
using Utility.Model;

namespace Utility.UI.Authority
{
    public partial class FrmModifyPwd : Form
    {
        //一般来说，控件初始化应放在窗体的load事件中处理
        //而非在构造函数中处理，因为其它类传递数据给窗体时，
        //是在窗体实例化之后，所以窗体实例化时（即调用构造函数）
        //无法接收其它类传递的数据，除非构造函数带上参数
        public FrmModifyPwd()
        {
            InitializeComponent();
            
        }


        #region 属性

        public string userCode { get; set; }

        #endregion

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        private void initializeDatasource()
        {
            ModifyPwdEventArgs modify = new ModifyPwdEventArgs();
            cmb_user.DataSource = new PersonService().people().Where<Person>(c => c.FailuerDate == null && c.Code == userCode).
                Select((c) => new { c.Code, c.Name, c.pwd, c.EffectDate }).ToList();

            cmb_user.DisplayMember = "name";
            cmb_user.ValueMember = "Code";

        }

        #region 事件

        public event EventHandler<ModifyPwdEventArgs> authorizPass;

        /// <summary>
        /// 事件处理方法,调用端实例化事件委托后就执行该方法
        /// authorizPass?本质上相当于执行方法时的第二次判断
        /// 引发事件是执行事件处理方法的第一次判断
        /// </summary>
        /// <param name="authorizationEventArgs"></param>
        protected virtual void onAuthorizPass(ModifyPwdEventArgs modifyPwdEventArgs)
        {
            authorizPass?.Invoke(this, modifyPwdEventArgs);
        }

        #endregion


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_certain_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            if (txt_pwd.Text != "" && txt_newPwd.Text != "")
            {
                string pwd = Encrypt.Encode(txt_pwd.Text);


                if (new PersonService().LoginValidate(cmb_user.SelectedValue.ToString(), pwd))
                {
                    //引发事件并传递事件包含的数据，该事件检验用户名密码是否正确
                    ModifyPwdEventArgs auth = new ModifyPwdEventArgs();
                    auth.userAndPwdRight = true;
                    auth.pwd = txt_newPwd.Text;
                    onAuthorizPass(auth);

                    this.Close();
                }


                else
                {

                    lbl_information.Text = "";
                    lbl_information.Text = lbl_information.Text + "您输入原密码不正确，请重新输入";
                    txt_newPwd.Text = "";

                }

            }
            else
            {
                lbl_information.Text = "";
                lbl_information.Text = "请输入密码";

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }


        private void Frm_modifyPwd_Load(object sender, EventArgs e)
        {
            initializeDatasource();
        }
    }

    /// <summary>
    /// 事件数据类，传递验证成功数据，类似于模型类，用于存储数据
    /// </summary>
    public class ModifyPwdEventArgs : EventArgs

    {

        public bool userAndPwdRight { get; set; }

        public string pwd { get; set; }


    }
}
