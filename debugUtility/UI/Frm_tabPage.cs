﻿using System.Drawing;
using System.Windows.Forms;

public class Frm_tabPage : Form
{
    private TabControl tabControl1;
    private Rectangle myTabRect;

    public Frm_tabPage()
    {
        tabControl1 = new TabControl();
        TabPage tabPage1 = new TabPage();

        tabControl1.Controls.Add(tabPage1);
        tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
        tabControl1.Location = new Point(25, 25);
        tabControl1.Size = new Size(250, 250);

        tabPage1.TabIndex = 0;
        

        // Gets the tabPage1 tab area defined by its TabIndex.
        // Returns a Rectangle to myTabRect.
        myTabRect = tabControl1.GetTabRect(0);

        ClientSize = new Size(300, 300);
        Controls.Add(tabControl1);

        tabControl1.DrawItem += new DrawItemEventHandler(OnDrawItem);
    }

    private void OnDrawItem(object sender, DrawItemEventArgs e)
    {
        Graphics g = e.Graphics;
        Pen p = new Pen(Color.Blue);
        g.DrawRectangle(p, myTabRect);
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Name = "Form1";
            this.ResumeLayout(false);

    }
}