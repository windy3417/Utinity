using DebugUtility.DAL;
using DebugUtility.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace debugUtility.UI
{
    public partial class Config : Utility.UI.Frm_DoubleDB_loginConfig
    {
        public Config()
        {
            InitializeComponent();
        }

        protected override void adminSetUp()
        {
            using (var db=new TestContext())
            {
                UserModle m = new UserModle();

                m.userID = base.txt_adminCode.Text;
                m.name = base.txt_adminName.Text;
                m.pwd = base.txt_adminPwd.Text;
                m.RegistrationDate = DateTime.Now;

                db.Users.Add(m);
                db.SaveChanges();
            }
           
        }
    }
}
