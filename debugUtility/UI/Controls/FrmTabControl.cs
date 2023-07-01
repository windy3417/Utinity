using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugUtility.UI.Controls
{
    public partial class FrmTabControl : Form
    {

      public  FrmTabControl()
        {
            InitializeComponent();
            MyTabs();

        }
    
            // Allows access to the DrawItem event. 
        
        private TabControl tabControl1=new TabControl();
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;

        private void MyTabs()
        {
    
            this.tabPage1 = new TabPage();
            this.tabPage2 = new TabPage();
            this.tabPage3 = new TabPage();
            this.tabPage4 = new TabPage();

            // Allows more than one row of tabs.
            this.tabControl1.Multiline = true;

            this.tabControl1.Padding = new Point(22, 5);
            this.tabControl1.Controls.AddRange(new Control[] {
            this.tabPage1,
            this.tabPage2,
            this.tabPage3,
            this.tabPage4});
            this.tabControl1.Location = new Point(35, 25);
            this.tabControl1.Size = new Size(220, 220);

            this.tabPage1.Text = "myTabPage1";
            this.tabPage2.Text = "myTabPage2";
            this.tabPage3.Text = "myTabPage3";
            this.tabPage4.Text = "myTabPage4";

            this.Size = new Size(300, 300);
            this.Controls.AddRange(new Control[] {
            this.tabControl1});
        }

    

    private Rectangle tabArea;
        private RectangleF tabTextArea;
        private RectangleF buttonBounds;
 



        // Declares the event handler DrawOnTab which is a method that
        // draws a string and Rectangle on the tabPage1 tab.
        private void DrawOnTab(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue);
            Font font = new Font("Arial", 10.0f);
            SolidBrush brush = new SolidBrush(Color.Red);

            g.DrawRectangle(p, tabArea);
            g.DrawString("jhg", font, brush, tabTextArea);
            g.DrawString("X", font, Brushes.Black, buttonBounds);
        }



    }
}

