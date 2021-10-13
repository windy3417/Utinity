using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugUtility.UI.ClassTest
{
    public partial class FrmEncrypt : Form
    {
        public FrmEncrypt()
        {
            InitializeComponent();
        }

        private void tsbSha1_Click(object sender, EventArgs e)
        {

            rtbEncrypted.Text = Utility.Encrypt.Sha1(rtbText.Text);
        }
    }
}
