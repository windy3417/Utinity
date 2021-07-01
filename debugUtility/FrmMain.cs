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
using DebugUtility.UI;
using debugUtility.UI.Print;
using debugUtility.UI;

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

        private void 登录数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoubleDB_loginConfig f  = new Frm_DoubleDB_loginConfig();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Config  f = new Config();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void 档案列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Frm_listTest f = new UI.Frm_listTest();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_treeView f = new Frm_treeView();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void it数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItDoubleDbConfig f = new FrmItDoubleDbConfig();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richBox f = new richBox();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void TsmCalarderColumn_Click(object sender, EventArgs e)
        {
            FrmCalarderColumn f = new FrmCalarderColumn();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void TsmButtonColumn_Click(object sender, EventArgs e)
        {
            FrmButtonColumn f = new FrmButtonColumn();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void treeViewColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTreeViewColumn f = new FrmTreeViewColumn();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void dataGridViewExtentionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataGridViewExtention f = new FrmDataGridViewExtention();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void importFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportExcel f = new FrmImportExcel();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void mutiPagePrintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMutiplePagePrinting f = new FrmMutiplePagePrinting();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }
    }
}


