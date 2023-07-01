using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DebugUtility.DAL;
using ReportTransfer.DAL;
using Utility.Excel;
using Utility.Files;

namespace DebugUtility.UI
{
    public partial class FrmReport : Form
    {
        Dictionary<string, string> kvName = new Dictionary<string, string>();
        Dictionary<string, string> kvAddress = new Dictionary<string, string>();
        public FrmReport()
        {
            InitializeComponent();
            InitializeDataSource();
        }

        void InitializeDataSource()
        {
            bind_DG_datasource();



        }

        private void bind_DG_datasource()
        {
            this.dataGridView1.AutoGenerateColumns = true;
            //this.dataGridView1.DataSource = new UserService().getCustomerSets();

            kvName.Add("01", "susan");
            kvName.Add("02", "windy");


            kvAddress.Add("01", "changSha");
            kvAddress.Add("02", "zhuZou");

            var query = from n in kvName
                        join a in kvAddress
                          on n.Key equals a.Key
                        select new { userID = n.Key, userNaem = n.Value, address = a.Value };
            this.dataGridView1.DataSource = query.ToList();


        }

        private void Frm_report_Load(object sender, EventArgs e)
        {
            //this.bind_DG_datasource();
        }

        private void Tsb_query_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = new UserService().getCustmer();
            using (var db =new U8Context())
            {
                dataGridView1.DataSource = db.Code.ToList();
            }

        }

        private void Tsb_export_Click(object sender, EventArgs e)
        {
            ExportExcel exportExcel = new ExportExcel();
            exportExcel.ExportExcelWithNPOI(new UserService().getCustmer(), "test");
        }

        private void tsb_exportDgv_Click(object sender, EventArgs e)
        {
            ExportExcel exportExcel = new ExportExcel();
            exportExcel.ExportExcelWithNPOI(dataGridView1,"测试导出dataGridVies中的数据");
        }

        private void tsb_exportCsv_Click(object sender, EventArgs e)
        {
            var myExport = new CsvExport();

            myExport.AddRow();
            myExport["Region"] = "Los Angeles, USA";
            myExport["Sales"] = 100000;
            myExport["Date Opened"] = new DateTime(2003, 12, 31);

            myExport.AddRow();
            myExport["Region"] = "Canberra \"in\" Australia";
            myExport["Sales"] = 50000;
            myExport["Date Opened"] = new DateTime(2005, 1, 1, 9, 30, 0);

            myExport.ExportToFile("Somefile.csv");
        }

        private void tsbRowSpan_Click(object sender, EventArgs e)
        {

            DataGridViewHelper helper = new DataGridViewHelper(this.dataGridView1);
            helper.Headers.Add(new DataGridViewHelper.TopHeader(1, 4, "总计"));

            this.dataGridView1.ColumnHeadersHeight = 50; //设置Dgv属性ColumnHeadersHeightSizeMode才会生效

        }
    }
}
