using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.UControl
{
    public partial class XmTextBoxWithButton : TextBox
    {

        public XmTextBoxWithButton()
        {
            InitializeComponent();
         
            this._refButton = new Button();
            this.Controls.Add(this._refButton);
            this.RenderControl();
        }


        #region vary
             
         Button _refButton;

        #endregion

        #region property

        public Button RefButton { get => _refButton; set => _refButton = value; }

        #endregion

        public void RenderControl()
        {
           
            this._refButton.Location = new Point(this.Width -21, 0);
            this._refButton.Width = 17;
            this._refButton.Height = 17;
            _refButton.Margin = new Padding(3,3,3,3);
            _refButton.Image = Properties.Resources.button;
            _refButton.MouseHover += _refButton_MouseHover;
            _refButton.Leave += _refButton_Leave;
            _refButton.Parent = this;
            _refButton.Anchor = AnchorStyles.Right;
        }

        private void _refButton_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void _refButton_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
