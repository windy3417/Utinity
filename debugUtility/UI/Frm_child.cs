using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.Sql;

namespace DebugUtility
{
    public partial class Frm_child : Form
    {
        public Frm_child()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(closeParent);
        }

        private void closeParent(object sender, FormClosedEventArgs formClosedEventArgs)
        { this.Parent.Dispose(); }
        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "update inventory_sub set binvasset = 0 where cInvSubCode=@updateString";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@updateString",txt_mendDate.Text.Trim() )
            };

            int influnceRows = Sqlhelper.UpdateWithparameters(sql, sqlParameters);
            MessageBox.Show("更新" + influnceRows + "条记录", "数据修改提示");

        }
    }
}
