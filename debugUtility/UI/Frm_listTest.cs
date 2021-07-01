using DebugUtility.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DebugUtility.Modle;
namespace DebugUtility.UI
{
    public partial class Frm_listTest : Utility.UI.Frm_archiveList
    {
        public Frm_listTest()
        {
            InitializeComponent();
            initialzeControlState();
            
        }

        void initialzeControlState()
        {
            
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            //UserModle m = new UserModle();
            //var mType = m.GetType();
            

            DataGridViewColumn userID = new DataGridViewColumn();
            userID.HeaderText = "用户编码";
            userID.DataPropertyName = "userID";
            userID.CellTemplate = cell;
            base.dgv_templet.Columns.Add(userID);

            DataGridViewColumn name = new DataGridViewColumn();
            name.HeaderText = "用户名称";
            name.DataPropertyName = "name";
            name.CellTemplate = cell;
            base.dgv_templet.Columns.Add(name);

            DataGridViewColumn pwd = new DataGridViewColumn();
            pwd.HeaderText = "密码";
            pwd.DataPropertyName ="pwd";
            pwd.CellTemplate = cell;
            base.dgv_templet.Columns.Add(pwd);


        }

    
        protected override void query()
        {
            using (var db = new TestContext())
            {

                try
                {
                    var query = from q in db.Users
                                select q;
                                 

                    base.dgv_templet.DataSource = query.OrderBy(o => o.userID).ToList();

                    //处理数据为空示和时的数据转换错误，可先转成泛型再求和
                    lbl_sum.Text = query.ToList().Count().ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("数据查询错误:" + ex.Message + ex.InnerException, "数据查询提示");
                    return;
                }
            }
        }
    }
}
