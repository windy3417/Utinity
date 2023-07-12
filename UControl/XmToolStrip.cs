using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.UControl
{
    public partial class XmToolStrip : ToolStrip
    {
        public XmToolStrip()
        {
            InitializeComponent();
            InitializeControl();
            BindClickEvent();
        }


        void InitializeControl()
        {

            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbAudit = new System.Windows.Forms.ToolStripButton();
            this.tsbGiveUpAudit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbSave,
            this.tsbUpdate,
            this.tsbAudit,
            this.tsbGiveUpAudit,
            this.tsbDelete});
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "toolStrip1";
            this.Size = new System.Drawing.Size(100, 25);
            this.TabIndex = 0;
            this.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Utility.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(53, 22);
            this.tsbAdd.Text = "新增";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::Utility.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "保存";
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbUpdate.Image = global::Utility.Properties.Resources.edit;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(23, 23);
            this.tsbUpdate.Text = "修改";
            // 
            // tsbAudit
            // 
            this.tsbAudit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbAudit.Image = global::Utility.Properties.Resources.Approve;
            this.tsbAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAudit.Name = "tsbAudit";
            this.tsbAudit.Size = new System.Drawing.Size(23, 23);
            this.tsbAudit.Text = "审核";
            // 
            // tsbGiveUp
            // 
            this.tsbGiveUpAudit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tsbGiveUpAudit.Image = global::Utility.Properties.Resources.giveUpAudit;
            this.tsbGiveUpAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGiveUpAudit.Name = "tsbGiveUp";
            this.tsbGiveUpAudit.Size = new System.Drawing.Size(23, 23);
            this.tsbGiveUpAudit.Text = "弃审";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Utility.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 23);
            this.tsbDelete.Text = "删除";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.ResumeLayout(false);



            tsbSave.Enabled = false;
            tsbAudit.Enabled = false;
            tsbGiveUpAudit.Enabled = false;
            tsbDelete.Enabled = false;
            tsbUpdate.Enabled = false;
        }

        void BindClickEvent()
        {

            this.tsbAdd.Click += TsbAdd_Click;
            this.tsbSave.Click += TsbSave_Click;
            this.tsbUpdate.Click += TsbUpdate_Click;
            this.tsbAudit.Click += TsbAudit_Click;
            this.tsbGiveUpAudit.Click += TsbGiveUp_Click;
            this.tsbDelete.Click += TsbDelete_Click;

        }

        #region vary

        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbAudit;
        private System.Windows.Forms.ToolStripButton tsbGiveUpAudit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
         ToolStripButton tsbUpdateSave = new ToolStripButton();


        DataGridView _tableBody;
        Panel _panelHeader;

        bool editFlag;


        #endregion


        #region properties

        public DataGridView TableBody { get => _tableBody; set => _tableBody = value; }
        public Panel PannelHeader { get => _panelHeader; set => _panelHeader = value; }

        #endregion

        #region menu clike logic

        private void TsbUpdate_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;


            if (CheckAudit())
            {

                MessageBox.Show("请先弃审，再修改！");
                Cursor = Cursors.Default;
                return;
            }

            else
            {
                tsbSave.Visible = false;
                tsbAudit.Enabled = false;
                tsbGiveUpAudit.Enabled = false;
                tsbDelete.Enabled = false;


                tsbUpdateSave.Enabled = true;
                tsbUpdateSave.Text = "保存";
                tsbUpdateSave.Image = tsbSave.Image;
                tsbUpdateSave.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                this.Items.Insert(this.Items.IndexOf(tsbSave), tsbUpdateSave);
                tsbUpdateSave.Visible = true;


                tsbUpdateSave.Click += TsbUpdateSave_Click;


            }





            Cursor = Cursors.Default;
        }


        private void TsbGiveUp_Click(object sender, EventArgs e)
        {
            if (GiveUpAudit())
            {
                MessageBox.Show("弃审完成");
                tsbAudit.Enabled = true;
            }

            else
            {
                MessageBox.Show("该单据还未审核，勿需弃审！");
            }
        }

        private void TsbAudit_Click(object sender, EventArgs e)
        {
            if (Audit())
            {
                MessageBox.Show("审核完成");
                tsbAudit.Enabled = false;
            }

            else
            {
                MessageBox.Show("该单据已经审核，请勿再次审核！");
            }

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


        private  void TsbSave_Click(object sender, EventArgs e)
        {
            if (CheckData(_tableBody, _panelHeader))
            {
                this.Cursor = Cursors.WaitCursor;


                if (_tableBody.IsCurrentCellInEditMode)
                {
                    //input enter key to trigle cellEndEdit event
                    SendKeys.Send("{ENTER}");
                    editFlag = false;

                }

                else
                {
                    Save();
                    //menu logic
                    tsbSave.Enabled = false;
                    tsbAudit.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbUpdate.Enabled = true;

                    _panelHeader.Enabled = false;
                }

                this.Cursor = Cursors.Default;
            }
        }

        private  void TsbAdd_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < _panelHeader.Controls.Count; i++)
            {
                if (_panelHeader.Controls[i].GetType().Name == "TextBox" || _panelHeader.Controls[i].GetType().Name == "ComboBox")
                {

                    _panelHeader.Controls[i].Text = "";
                }
            }
            _panelHeader.Enabled = true;
            _tableBody.Rows.Clear();
          
            tsbUpdateSave.Visible = false;
            tsbUpdateSave.Enabled = false;
            tsbSave.Visible = true;
            _tableBody.Rows[0].Cells[0].Selected = true;

        }


        private void TsbDelete_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {


                if (CheckAudit())
                {
                    MessageBox.Show("该单据已经审核，不能删除！");
                    Cursor = Cursors.Default;
                    return;
                }


                if (Delete())
                {
                    MessageBox.Show("数据删除成功");
                    ClearUIData(_tableBody, _panelHeader);

                    tsbDelete.Enabled = false;
                    tsbUpdate.Enabled = false;
                    tsbAudit.Enabled = false;
                    tsbGiveUpAudit.Enabled = false;
                    tsbSave.Enabled = false;
                }


            

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }

            Cursor = Cursors.Default;

        }

     

        #endregion

        #region business logic

        private bool CheckData(DataGridView dgv, Panel panHeader)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("请参照录入表体行数据再保存！");
                return false;
            }
            foreach (var item in panHeader.Controls)
            {
                if (item.GetType().Name == "TextBox" && ((TextBox)item).Text == "")
                {
                    MessageBox.Show("表头必填项未填写！");
                    ((TextBox)item).BackColor = Color.Red;
                    ((TextBox)item).Focus();
                    return false;
                }
            }

            //if the content of all textBox is not empty,change the backColor of it 
            foreach (var item in panHeader.Controls)
            {

                if (item.GetType().Name == "TextBox")
                {

                    ((TextBox)item).BackColor = Color.White;

                }


            }
            return true;
        }

        private void ClearUIData(DataGridView dgv, Panel panHeader)
        {
            dgv.Rows.Clear();
            foreach (var item in panHeader.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        #endregion


        #region crud

        public virtual void Save()
        {
        }

        #region update

        public virtual bool Audit()
        {

            return false;

        }


        public virtual bool GiveUpAudit()
        {


            return false;
        }

        public virtual bool CheckAudit()
        {
            return false;
        }


        private void TsbUpdateSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private bool Delete()
        {
            return true;
        }


        #endregion
    }
}
