using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.UControl
{
    public partial class UtoolStrip : UserControl
    {
        public UtoolStrip()
        {
            InitializeComponent();
            this.ParentForm.FormClosed += new FormClosedEventHandler(closeParent);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();


        }

        private void closeParent(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            this.ParentForm.Parent.Dispose();
        }

        #region button事件

        #endregion
        public virtual void Tsb_save_Click(object sender, EventArgs e)
        {

        }
    }
}
