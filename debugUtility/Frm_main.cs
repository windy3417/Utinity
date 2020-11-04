using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using Utility;
using Utility.UI;

namespace DebugUtility
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
            tabControl1.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            this.initialize();
        }

        private void initialize()
        {
            if (ConfigurationManager.ConnectionStrings["myConcetion"] == null)
            {
                Frm_config frm_Config = new Frm_config();
                string tabPageText = frm_Config.Text;
                Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
                embed.openForm(frm_Config, tabPageText, tabControl1, panel1);
            }
        }

        private void 子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_child frm_Child = new Frm_child();
            string tabPageText = frm_Child.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(frm_Child, tabPageText, tabControl1, panel1);





        }

        private void 图片转ICONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.Frm_imageFormatConvert frm_Child = new Frm_imageFormatConvert();
            string tabPageText = frm_Child.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(frm_Child, tabPageText, tabControl1, panel1);
        }

        private void 数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoubleDataBaseConfig frm_Config = new Frm_DoubleDataBaseConfig();
            string tabPageText = frm_Config.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(frm_Config, tabPageText, tabControl1, panel1);
        }

        private void 单表合一ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_report frm_Config = new Frm_report();
            string tabPageText = frm_Config.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(frm_Config, tabPageText, tabControl1, panel1);
        }
    }
}
