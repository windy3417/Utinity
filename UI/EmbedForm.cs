using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.UI
{
    public class EmbedForm
    {
        /// <summary>
        /// 实现嵌入式窗体
        /// <param name="tabPageText"></param>
        /// </summary>
        /// <param name="formName">窗体名称</param>
        /// <param name="tabPageText">窗体在TabPage上显示的名称</param>
        /// <param name="tabControl">窗体所在容器</param>
        /// <param name="panel">tabControl所在容器</param>
        public void openForm(Form formName, string tabPageText, TabControl tabControl, Panel panel)
        {

            TabPage tp = new TabPage();
            tp.Text = tabPageText;
            tp.Name = tabPageText;


            //设置tabPage布局
            tabControl.Visible = true;
            tabControl.Controls.Add(tp);
            tabControl.Parent = panel;
            //设置窗体布局
            formName.TopLevel = false;
            tp.Controls.Add(formName);

            formName.Dock = DockStyle.Fill;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Parent = tp;
            formName.Show();
            //以代码形式选择选项卡
            tabControl.SelectedTab = tabControl.TabPages[tabPageText];//使用tabPage的Focus与Select方法均不能实现以代码形式选择选项卡
        }
    }
}
