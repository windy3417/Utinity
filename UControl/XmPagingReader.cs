using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Utility.Common;

namespace Utility.UControl
{
    //The first page of the report that invokes the paging control needs to be automatically summed up for the first time
    public partial class XmPagingReader : ToolStrip
    {
        public XmPagingReader()
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

        //The column names in the Datatable must be consistent with the column names in the dataGridView in order to make total and style modifications
        private string[] _columnsForSum;

        ToolStripButton tsbGoTo;

        DataGridView _tableBody;
        IEnumerable<DataRow> _dataSource;

        #endregion

        #region properties

        public DataGridView TableBody { get => _tableBody; set => _tableBody = value; }

        public IEnumerable<DataRow> DataSource { get => _dataSource; set => _dataSource = value; }

        public decimal PageSize { get =>Convert.ToDecimal( _txtPageSize.Text);set => _txtPageSize.Text = value.ToString(); }
        public decimal TotalPages { get => Convert.ToDecimal(_txtEndNo.Text); set => _txtEndNo.Text = value.ToString(); }
        public string StartNo { get => _txtStartNo.Text; set => _txtStartNo.Text = value; }
        public string[] ColumnsForSum { get => _columnsForSum; set => _columnsForSum = value; }
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
            this._txtPageSize.Size = new System.Drawing.Size(40, 25);
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
            this.tsbFirstPage.Text = "第一页";

            // 
            // tsbPrePage
            // 
            this.tsbPrePage = new ToolStripButton();
            this.tsbPrePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrePage.Image = Properties.Resources.previous_page;
            this.tsbPrePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrePage.Name = "tsbPrePage";
            this.tsbPrePage.Size = new System.Drawing.Size(23, 22);
            this.tsbPrePage.Text = "前一页";

            // 
            // tsbStartNo
            // 
            this._txtStartNo = new ToolStripTextBox();
            this._txtStartNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._txtStartNo.Name = "tsbStartNo";
            this._txtStartNo.Size = new System.Drawing.Size(40, 25);
            this._txtStartNo.Text = "1";
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
            this.tsbNextPage.Text = "下一页";

            // 
            // tsbLastPage
            // 
            this.tsbLastPage = new ToolStripButton();
            this.tsbLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLastPage.Image = Properties.Resources.Last_page;
            this.tsbLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLastPage.Name = "tsbLastPage";
            this.tsbLastPage.Size = new System.Drawing.Size(23, 22);
            this.tsbLastPage.Text = "最后一页";

            //tsbGoTo
            this.tsbGoTo = new ToolStripButton();
            this.tsbGoTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
       
           
            this.tsbGoTo.Name = "tsbGoTo";
            this.tsbGoTo.Size = new System.Drawing.Size(30, 22);
            this.tsbGoTo.Text = "跳转";


            // bnPaging
            // to align to right side of toolstrip, need to add toolstripItem reverse
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                tsbGoTo,
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
          
      
                     
                
            
           
           
            //either i++ from 0 or i-- from count ,the align result is the same 

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
            _txtPageSize.Enter += RedisplayAccordingPageSize;
        }

    
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #region  Access the contents of the specified page..
        private void RedisplayAccordingPageSize(object sender, EventArgs e)
        {
           _txtEndNo.Text= (Math.Ceiling(_dataSource.Count() /  Convert.ToDecimal(_txtPageSize.Text))).ToString();
            tsbFirstPage.PerformClick();
        }

        private void tsbFirstPage_Click(object sender, EventArgs e)
        {
            IEnumerable<DataRow> query = GetPagedData(_dataSource, 1);

            _txtStartNo.Text = "1";

            var q = query.CopyToDataTable();

            AddSumRow(q);

            _tableBody.DataSource = q;
            TableStyle();

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
            var query = GetPagedData(_dataSource, Convert.ToInt32(_txtEndNo.Text));

            _txtStartNo.Text = _txtEndNo.Text;
            _tableBody.DataSource = query.CopyToDataTable();
            TableStyle();

        }

        private void AddSumRow(DataTable q)
        {
            if (!(_columnsForSum is null))
            {
                
               
                              
                Dictionary<string, decimal> sums =new Dictionary<string, decimal>();
               
             
                foreach (var item in _columnsForSum)
                {
                    sums.Add(item,q.AsEnumerable().Sum(a => a.Field<decimal>(item)));
                                       
                }
                q.Rows.Add();
                int i = q.Rows.Count;
                foreach (var item in _columnsForSum)
                {
                    var l = sums[item];
                    q.Rows[i - 1].SetField<decimal>(item, sums[item]);
                    
                }
                
            }
        }
        #endregion

        #region get data

        public IEnumerable<T> GetPagedData<T>(IEnumerable<T> dataSource, int desingedPageNumber)
        {
            int skipCount = (desingedPageNumber - 1) * Convert.ToInt32( _txtPageSize.Text);
            return dataSource.Skip(skipCount).Take(Convert.ToInt32( _txtPageSize.Text));
        }
        #endregion

        #region bind data
        private void BindData()
        {
            var query = GetPagedData(_dataSource, Convert.ToInt32(_txtStartNo.Text));
            var q = query.CopyToDataTable();
            AddSumRow(q);
            _tableBody.DataSource = q;
            TableStyle();


        }

        private void TableStyle()
        {

            if (!(_columnsForSum is null))
            {
                Utility.Style.DataGridViewStyle style = new Utility.Style.DataGridViewStyle();
                style.ThoundSeparate(_tableBody, _columnsForSum);
                style.FontBond(_tableBody, _columnsForSum);

            }

        }

        #endregion





    }


}
