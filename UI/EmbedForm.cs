using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.UI
{
    public class EmbedForm
    {
        //选项卡所在位置
        private Rectangle tabArea;

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


        /// <summary>
        /// 实现嵌入式窗体
        /// <param name="tabPageText"></param>
        /// </summary>
        /// <param name="formName">窗体名称</param>
        /// <param name="tabPageText">窗体在TabPage上显示的名称</param>
        /// <param name="tabControl">窗体所在容器</param>
      
        public void openForm(Form formName, string tabPageText, TabControl tabControl)
        {

            TabPage tp = new TabPage();
            tp.Text = tabPageText;
            tp.Name = tabPageText;


            //设置tabPage布局
            tabControl.Visible = true;
            tabControl.Controls.Add(tp);
            //tabControl.Parent = panel;
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

        ///// <summary>
        ///// 实现嵌入式窗体
        ///// <param name="tabPageText"></param>
        ///// </summary>
        ///// <param name="formName">窗体名称</param>
        ///// <param name="tabPageText">窗体在TabPage上显示的名称</param>
        ///// <param name="tabControl">窗体所在容器</param>
        ///// <param name="panel">tabControl所在容器</param>
        //public void openFormWithClose(Form formName, string tabPageText, TabControl tabControl, Panel panel)
        //{

        //    TabPage tp = new TabPage();
        //    tp.Text = tabPageText;
        //    tp.Name = tabPageText;


        //    //重新绘制选项卡
        //    tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
        //    tabArea = tabControl.GetTabRect(tp.inde);
        //    tabControl.DrawItem += TabControl_DrawItem1;



        //    //设置tabPage布局
        //    tabControl.Visible = true;
        //    tabControl.Controls.Add(tp);
        //    tabControl.Parent = panel;
        //    //设置窗体布局
        //    formName.TopLevel = false;
        //    tp.Controls.Add(formName);

        //    formName.Dock = DockStyle.Fill;
        //    formName.FormBorderStyle = FormBorderStyle.None;
        //    formName.Parent = tp;
        //    formName.Show();
        //    //以代码形式选择选项卡
        //    tabControl.SelectedTab = tabControl.TabPages[tabPageText];//使用tabPage的Focus与Select方法均不能实现以代码形式选择选项卡
        //}

        //private void TabControl_DrawItem1(object sender, DrawItemEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}


        ////绘制“Ｘ”号即关闭按钮  
        //private void TabControl_DrawItem( TabControl tabControl, object sender, DrawItemEventArgs e)
        //{

        //    try
        //    {



        //        //先添加TabPage属性     
        //        e.Graphics.DrawString(tabControl.TabPages[e.Index].Text
        //        , tabControl.Font, SystemBrushes.ControlText, tabArea.X + 2, tabArea.Y + 2);

        //        //再画一个矩形框  
        //        using (Pen p = new Pen(Color.White))
        //        {
        //            tabArea.Offset(tabArea.Width - (CLOSE_SIZE + 3), 2);
        //            tabArea.Width = CLOSE_SIZE;
        //            tabArea.Height = CLOSE_SIZE;
        //            e.Graphics.DrawRectangle(p, tabArea);

        //        }

        //        //填充矩形框  
        //        Color recColor = e.State == DrawItemState.Selected ? Color.White : Color.White;
        //        using (Brush b = new SolidBrush(recColor))
        //        {
        //            e.Graphics.FillRectangle(b, tabArea);
        //        }

        //        //画关闭符号  
        //        using (Pen objpen = new Pen(Color.Black))
        //        {
        //            //"\"线  
        //            Point p1 = new Point(tabArea.X + 3, tabArea.Y + 3);
        //            Point p2 = new Point(tabArea.X + tabArea.Width - 3, tabArea.Y + tabArea.Height - 3);
        //            e.Graphics.DrawLine(objpen, p1, p2);

        //            //"/"线  
        //            Point p3 = new Point(tabArea.X + 3, tabArea.Y + tabArea.Height - 3);
        //            Point p4 = new Point(tabArea.X + tabArea.Width - 3, tabArea.Y + 3);
        //            e.Graphics.DrawLine(objpen, p3, p4);
        //        }

        //        e.Graphics.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //}
        ////=======================================================================  

    }
}
