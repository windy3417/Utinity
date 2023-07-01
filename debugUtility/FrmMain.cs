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
using debugUtility.UI.ClassTest;
using DebugUtility.UI.ClassTest;
using Utility.UI.Authority;
using DebugUtility.UI.Controls;

namespace DebugUtility
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.initialize();
            // Allows access to the DrawItem event. 


            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            //tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            

            tabControl1.ItemSize = new Size(80, 19);

            // Binds the event handler DrawOnTab to the DrawItem event 
            // through the DrawItemEventHandler delegate.
            tabControl1.DrawItem += tabControl1_DrawItem;
        }

        #region vary
        int i = 0;

        TabControl tabControl1 = new TabControl();
        private Rectangle tabArea;
        private RectangleF tabTextArea;
        private RectangleF buttonBounds;
        #endregion

        #region 打开子窗体

        private void 子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_child frm_Child = new Frm_child();
            string tabPageText = frm_Child.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(frm_Child, tabPageText, tabControl1, panel1);





        }


        private void tabPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTabControl f = new FrmTabControl();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
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
            FrmReport frm_Config = new FrmReport();
            string tabPageText = frm_Config.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(frm_Config, tabPageText, tabControl1, panel1);
        }

        private void 登录数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoubleDB_loginConfig f = new Frm_DoubleDB_loginConfig();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config f = new Config();
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

            FrmTreeView f = new FrmTreeView();
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

        private void 业务及外挂数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoginConfigDB f = new FrmLoginConfigDB();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void classTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComboxColumn f = new FrmComboxColumn();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }



        #endregion

        // Declares the event handler DrawOnTab which is a method that
        // draws a string and Rectangle on the tabPage1 tab.
        private void DrawOnTab(object sender, DrawItemEventArgs e)
        {
            tabArea = tabControl1.GetTabRect(e.Index);

            tabTextArea = new Rectangle(tabArea.Location, new Size(tabArea.Width - 16, tabArea.Height));
            buttonBounds = new Rectangle(tabArea.Right - 16, tabArea.Top, 16, 16);



            TabPage tabPage = tabControl1.TabPages[e.Index];
            string tabText = tabPage.Text;

            // Use a Graphics object to measure the text width
            using (Graphics g = e.Graphics)
            {

                SizeF textSize = g.MeasureString(tabText, tabPage.Font);

                // If the text overflows, replace the excess characters with an ellipsis
                if (textSize.Width > e.Bounds.Width)
                {
                    int ellipsisWidth = TextRenderer.MeasureText("...", tabPage.Font).Width;
                    int cutoff = 0;
                    for (int i = tabText.Length - 1; i >= 0; i--)
                    {
                        textSize = g.MeasureString(tabText.Substring(0, i) + "...", tabPage.Font);
                        if (textSize.Width + ellipsisWidth <= e.Bounds.Width)
                        {
                            cutoff = i;
                            break;
                        }
                    }
                    tabText = tabText.Substring(0, cutoff) + "...";
                }
            }

            // Draw the modified tab text


            Pen p = new Pen(Color.Blue);
            Font font = new Font("Arial", 10.0f);
            SolidBrush brush = new SolidBrush(Color.Red);

            //e.Graphics.DrawString(tabText, tabPage.Font, SystemBrushes.ControlText, e.Bounds.X + 3, e.Bounds.Y + 3);
            //e.Graphics.DrawRectangle(p, tabArea);
            e.Graphics.DrawString(tabText, font, brush, tabTextArea);
            e.Graphics.DrawString("X", font, Brushes.Black, buttonBounds);
        }
    
        private void initialize()
        {
            //if (ConfigurationManager.ConnectionStrings["myConcetion"] == null)
            //{
            //    Frm_config frm_Config = new Frm_config();
            //    string tabPageText = frm_Config.Text;
            //    Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            //    embed.openForm(frm_Config, tabPageText, tabControl1, panel1);
            //}
        }

       

        #region library test

        private void smbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSMB f = new FrmSMB();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void sha1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEncrypt f = new FrmEncrypt();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void erroProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.UI.Authority.FrmPerson f = new FrmPerson();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        private void readPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPDF f = new FrmPDF();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        #endregion

        #region 控件测试
        private void treeViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmTreeView f = new FrmTreeView();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        #endregion

        private void 普通单据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSheet f = new FrmSheet();
            string tabPageText = f.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(f, tabPageText, tabControl1, panel1);
        }

        /// <summary>
        /// custom header of tabpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            TabPage tabPage = tabControl.TabPages[e.Index];
         
            string tabText = tabPage.Text;
            // Create a font for drawing the close button
            var closeButtonFont = new Font("Segoe UI", 8, FontStyle.Regular);

            // Calculate the bounds of the tab header text and the button
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);
           
            Rectangle textBounds = new Rectangle(tabBounds.Location, new Size(tabBounds.Width - 16, tabBounds.Height));
          
            Rectangle buttonBounds = new Rectangle(tabBounds.Right - 16, tabBounds.Top, 16, 16);


            // Use a Graphics object to measure the text width
           

                SizeF textSize = e.Graphics.MeasureString(tabText, tabPage.Font);

                // If the text overflows, replace the excess characters with an ellipsis
                if (textSize.Width > e.Bounds.Width)
                {
                    int ellipsisWidth = TextRenderer.MeasureText("...", tabPage.Font).Width;
                    int cutoff = 0;
                    for (int i = tabText.Length - 1; i >= 0; i--)
                    {
                        textSize = e.Graphics.MeasureString(tabText.Substring(0, i) + "...", tabPage.Font);
                        if (textSize.Width + ellipsisWidth <= e.Bounds.Width)
                        {
                            cutoff = i;
                            break;
                        }
                    }
                    tabText = tabText.Substring(0, cutoff) + "...";
                }
            

            // Draw the tab header text
            TextRenderer.DrawText(e.Graphics, tabText, tabPage.Font, textBounds, tabPage.ForeColor, TextFormatFlags.Left);

            // Draw the button
        
            e.Graphics.DrawString("X", closeButtonFont, Brushes.Black, buttonBounds);

            // Store the button bounds in the Tag property of the tabPage
            tabPage.Tag = buttonBounds;
            
        }

        /// <summary>
        /// colse the child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;

            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                TabPage tabPage = tabControl.TabPages[i];
                Rectangle buttonBounds = (Rectangle)tabPage.Tag;

                if (buttonBounds.Contains(e.Location))
                {
                    // Close the child form of the tabPage
                    Form childForm = tabPage.Controls[0] as Form;
                    childForm.Close();

                    // Remove the tabPage from the tabControl
                    tabControl.TabPages.RemoveAt(i);
                    break;
                }
            }

           
        }


        /// <summary>
        /// open form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemClick(object sender, EventArgs e)
        {


            ToolStripItem toolStripItem = (ToolStripItem)sender;
                // Instantiate the form using reflection
                Type formType = Type.GetType("DebugUtility.UI."+toolStripItem.Name);
                Form form = (Form)Activator.CreateInstance(formType);

                       
            string tabPageText = form.Text;
            Utility.UI.EmbedForm embed = new Utility.UI.EmbedForm();
            embed.openForm(form, tabPageText, tabControl1, panel1);





        }



    }
}


