namespace DebugUtility
{
    partial class Frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.horizonLine1 = new Utility.UControl.HorizonLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.子窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图形处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图片转ICONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录数据库配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单表合一ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // horizonLine1
            // 
            this.horizonLine1.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(254, 249);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(288, 1);
            this.horizonLine1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.子窗体ToolStripMenuItem,
            this.图形处理ToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.报表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 子窗体ToolStripMenuItem
            // 
            this.子窗体ToolStripMenuItem.Name = "子窗体ToolStripMenuItem";
            this.子窗体ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.子窗体ToolStripMenuItem.Text = "子窗体";
            this.子窗体ToolStripMenuItem.Click += new System.EventHandler(this.子窗体ToolStripMenuItem_Click);
            // 
            // 图形处理ToolStripMenuItem
            // 
            this.图形处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图片转ICONToolStripMenuItem});
            this.图形处理ToolStripMenuItem.Name = "图形处理ToolStripMenuItem";
            this.图形处理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图形处理ToolStripMenuItem.Text = "图形处理";
            // 
            // 图片转ICONToolStripMenuItem
            // 
            this.图片转ICONToolStripMenuItem.Name = "图片转ICONToolStripMenuItem";
            this.图片转ICONToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.图片转ICONToolStripMenuItem.Text = "图片转ICON";
            this.图片转ICONToolStripMenuItem.Click += new System.EventHandler(this.图片转ICONToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库配置ToolStripMenuItem,
            this.登录数据库配置ToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // 数据库配置ToolStripMenuItem
            // 
            this.数据库配置ToolStripMenuItem.Name = "数据库配置ToolStripMenuItem";
            this.数据库配置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.数据库配置ToolStripMenuItem.Text = "数据库配置";
            this.数据库配置ToolStripMenuItem.Click += new System.EventHandler(this.数据库配置ToolStripMenuItem_Click);
            // 
            // 登录数据库配置ToolStripMenuItem
            // 
            this.登录数据库配置ToolStripMenuItem.Name = "登录数据库配置ToolStripMenuItem";
            this.登录数据库配置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.登录数据库配置ToolStripMenuItem.Text = "登录数据库配置";
            this.登录数据库配置ToolStripMenuItem.Click += new System.EventHandler(this.登录数据库配置ToolStripMenuItem_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单表合一ToolStripMenuItem});
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // 单表合一ToolStripMenuItem
            // 
            this.单表合一ToolStripMenuItem.Name = "单表合一ToolStripMenuItem";
            this.单表合一ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.单表合一ToolStripMenuItem.Text = "单表合一";
            this.单表合一ToolStripMenuItem.Click += new System.EventHandler(this.单表合一ToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminToolStripMenuItem.Text = "admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.horizonLine1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_main";
            this.Text = "主窗体";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utility.UControl.HorizonLine horizonLine1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem 子窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图形处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图片转ICONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单表合一ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录数据库配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
    }
}

