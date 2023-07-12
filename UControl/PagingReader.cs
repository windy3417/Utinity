using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.UControl
{
    public partial class PagingReader : ToolStrip
    {
        public PagingReader()
        {
            InitializeComponent();
            InitializeControls();
            BindButtonClickEvent();
           
        }

        #region vary

        private System.Windows.Forms.ToolStripLabel labDisplayPerPage;
        private System.Windows.Forms.ToolStripTextBox _txtPageSize;
        private System.Windows.Forms.ToolStripLabel labRow;
        private System.Windows.Forms.ToolStripSeparator sepButton;
        private System.Windows.Forms.ToolStripButton tsbFirstPage;

        private System.Windows.Forms.ToolStripTextBox _txtStartNo;
        private System.Windows.Forms.ToolStripLabel labNumber;
        private System.Windows.Forms.ToolStripTextBox _txtEndNo;
        private System.Windows.Forms.ToolStripButton tsbPrePage;
        private System.Windows.Forms.ToolStripButton tsbNextPage;
        private System.Windows.Forms.ToolStripButton tsbLastPage;

        DataGridView _tableBody;
        IEnumerable<DataRow> _dataSource;

        #endregion

        #region properties

        public DataGridView TableBody { get => _tableBody; set => _tableBody = value; }

        public IEnumerable<DataRow> DataSource { get => _dataSource; set => _dataSource = value; }

        public string PageSize { get => _txtPageSize.Text;set => _txtPageSize.Text = value; }
        public string TotalPages { get => _txtEndNo.Text; set => _txtEndNo.Text = value; }
        public string StartNo { get => _txtStartNo.Text; set => _txtStartNo.Text = value; }
        #endregion

        void InitializeControls()
        {

            // 
            // labDisplayPerPage
            // 
            this.labDisplayPerPage = new ToolStripLabel();
            //labDisplayPerPage.Alignment = ToolStripItemAlignment.Right;
            
            this.labDisplayPerPage.Name = "labDisplayPerPage";
            this.labDisplayPerPage.Size = new System.Drawing.Size(59, 22);
            this.labDisplayPerPage.Text = "每页显示";
            // 
            // txtPageSize
            // 
            //_txtPageSize.Alignment = ToolStripItemAlignment.Right;
            this._txtPageSize = new ToolStripTextBox();
            this._txtPageSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._txtPageSize.Name = "txtPageSize";
            this._txtPageSize.Size = new System.Drawing.Size(20, 25);
            this._txtPageSize.Text = "10";
            // 
            // labRow
            // 
            this.labRow = new ToolStripLabel();
            this.labRow.Name = "labRow";
            this.labRow.Size = new System.Drawing.Size(20, 22);
            this.labRow.Text = "条";
            // 
            // sepButton
            // 
            this.sepButton = new ToolStripSeparator();
            this.sepButton.Name = "sepButton";
            this.sepButton.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFirstPage
            // 
            this.tsbFirstPage = new ToolStripButton();
            this.tsbFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFirstPage.Image = Properties.Resources.first_page;
            this.tsbFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFirstPage.Name = "tsbFirstPage";
            this.tsbFirstPage.Size = new System.Drawing.Size(23, 22);
            this.tsbFirstPage.Text = "toolStripButton1";

            // 
            // tsbPrePage
            // 
            this.tsbPrePage = new ToolStripButton();
            this.tsbPrePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrePage.Image = Properties.Resources.previous_page;
            this.tsbPrePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrePage.Name = "tsbPrePage";
            this.tsbPrePage.Size = new System.Drawing.Size(23, 22);
            this.tsbPrePage.Text = "toolStripButton1";

            // 
            // tsbStartNo
            // 
            this._txtStartNo = new ToolStripTextBox();
            this._txtStartNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._txtStartNo.Name = "tsbStartNo";
            this._txtStartNo.Size = new System.Drawing.Size(20, 25);
            this._txtStartNo.Text = "0";
            // 
            // labNumber
            // 
            this.labNumber = new ToolStripLabel();
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(12, 22);
            this.labNumber.Text = "/";
            // 
            // tsbEndNo
            // 
            this._txtEndNo = new ToolStripTextBox();
            this._txtEndNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._txtEndNo.Name = "tsbEndNo";
            this._txtEndNo.Size = new System.Drawing.Size(30, 25);
            this._txtEndNo.Text = "0";
            // 
            // tsbNextPage
            // 
            this.tsbNextPage = new ToolStripButton();
            this.tsbNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextPage.Image = Properties.Resources.Next_page;
            this.tsbNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNextPage.Name = "tsbNextPage";
            this.tsbNextPage.Size = new System.Drawing.Size(23, 22);
            this.tsbNextPage.Text = "toolStripButton1";

            // 
            // tsbLastPage
            // 
            this.tsbLastPage = new ToolStripButton();
            this.tsbLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLastPage.Image = Properties.Resources.Last_page;
            this.tsbLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLastPage.Name = "tsbLastPage";
            this.tsbLastPage.Size = new System.Drawing.Size(23, 22);
            this.tsbLastPage.Text = "toolStripButton1";

            // bnPaging
            // to align to right side of toolstrip, need to add toolstripItem reverse
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLastPage,
              this.tsbNextPage,
             this._txtEndNo,
            this.labNumber,
             this._txtStartNo,
               this.tsbPrePage,
            this.tsbFirstPage,
             this.sepButton,
            this.labRow,
            this._txtPageSize,
             this.labDisplayPerPage});
          
      
                  
           
                
            
           
           
            //either i++ from 0 or i-- from count ,the result is the same 

            for (int i =this.Items.Count-1 ; i>=0 ; i--)
            
            {
                this.Items[i].Alignment = ToolStripItemAlignment.Right;
            }
            

            
          
        
         
        }

       void BindButtonClickEvent()

        {
            this.tsbFirstPage.Click += new System.EventHandler(this.tsbFirstPage_Click);
            this.tsbPrePage.Click += new System.EventHandler(this.tsbPrePage_Click);
            this.tsbNextPage.Click += new System.EventHandler(this.tsbNextPage_Click);
            this.tsbLastPage.Click += new System.EventHandler(this.tsbLastPage_Click);
        }

   

    

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #region implemnet pageing

        private void tsbFirstPage_Click(object sender, EventArgs e)
        {
            IEnumerable<DataRow> query = GetPagedData(_dataSource, 1, Convert.ToInt32(_txtPageSize.Text));

            _txtStartNo.Text = "1";
            _tableBody.DataSource = query.ToList();
          
        }

        private void tsbPrePage_Click(object sender, EventArgs e)
        {
            int startNo;
            startNo = Convert.ToInt32(_txtStartNo.Text);
            if (startNo > 1)
            {
                _txtStartNo.Text = (Convert.ToInt32(_txtStartNo.Text) - 1).ToString();
                tsbPrePage.Enabled = true;
                tsbNextPage.Enabled = true;
                BindData();
                return;
            }
            tsbPrePage.Enabled = false;
        }

        private void tsbNextPage_Click(object sender, EventArgs e)
        {
            int startNo;
            startNo = Convert.ToInt32(_txtStartNo.Text);
            if (startNo < Convert.ToInt32(_txtEndNo.Text))
            {
                _txtStartNo.Text = (Convert.ToInt32(_txtStartNo.Text) + 1).ToString();
                tsbPrePage.Enabled = true;
                tsbNextPage.Enabled = true;
                BindData();
                return;
            }

            tsbNextPage.Enabled = false;

        }


        private void tsbLastPage_Click(object sender, EventArgs e)
        {
            var query = GetPagedData(_dataSource, Convert.ToInt32(_txtEndNo.Text), Convert.ToInt32(_txtPageSize.Text));

            _txtStartNo.Text = _txtEndNo.Text;
            _tableBody.DataSource = query.ToList();
           
        }

        #endregion

        #region get data

        public IEnumerable<T> GetPagedData<T>(IEnumerable<T> data, int pageNumber, int pageSize)
        {
            int skipCount = (pageNumber - 1) * pageSize;
            return data.Skip(skipCount).Take(pageSize);
        }

        private void BindData()
        {
            var query = GetPagedData(_dataSource, Convert.ToInt32(_txtStartNo.Text), Convert.ToInt32(_txtPageSize.Text));


            _tableBody.DataSource = query.ToList
                ();
           
        }


        #endregion


    }


}
