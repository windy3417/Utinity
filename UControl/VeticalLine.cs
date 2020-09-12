using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Utility.UControl
{
 
   
        　　/// LineY 画竖线控件
        　　///
        public class VeticalLine : System.Windows.Forms.UserControl
        {
            #region 属性定义
            private System.Drawing.Color lineColor;
            private int lineWidth;
            ///
            　　/// 线的颜色属性
            　　///
            public System.Drawing.Color LineColor
            {
                set
                {
                    this.lineColor = value;
                    System.Windows.Forms.PaintEventArgs ep =
                    new PaintEventArgs(this.CreateGraphics(),
                    this.ClientRectangle);
                    this.LineY_Paint(this, ep);
                }
                get { return this.lineColor; }
            }
            ///
            　　/// 线的粗细
            　　///
            public int LineWidth
            {
                set
                {
                    this.lineWidth = value;
                    System.Windows.Forms.PaintEventArgs ep =
                    new PaintEventArgs(this.CreateGraphics(),
                    this.ClientRectangle);
                    this.LineY_Paint(this, ep);
                }
                get { return this.lineWidth; }
            }
            #endregion
            private System.ComponentModel.Container components = null;
            ///
            　　/// 构造函数初始颜色和线粗细
            　　///
            public VeticalLine()
            {
                InitializeComponent();
                this.lineColor = this.ForeColor;
                this.lineWidth = 1;
            }
            ///
            　　/// 清理所有正在使用的资源。
            　　///
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    if (components != null)
                    {
                        components.Dispose();
                    }
                }
                base.Dispose(disposing);
            }
            #region 组件设计器生成的代码
            ///
            　　/// 设计器支持所需的方法 - 不要使用代码编辑器
            　　/// 修改此方法的内容。
            　　///
            private void InitializeComponent()
            {
                //
                // LineY
                //
                this.Name = "LineY";
                this.Resize +=
                new System.EventHandler(this.LineY_Resize);
                this.Paint +=
                new System.Windows.Forms.PaintEventHandler(this.LineY_Paint);
            }
            #endregion
            private void LineY_Paint(
          object sender, System.Windows.Forms.PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Pen myPen = new Pen(this.lineColor);
                myPen.Width = this.lineWidth * 2;
                this.Width = this.LineWidth;
                g.DrawLine(myPen, 0, 0, 0, e.ClipRectangle.Bottom);
            }
            private void LineY_Resize(
            object sender, System.EventArgs e)
            {
                this.Width = this.lineWidth;
            }
        }
    }
