using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DebugUtility.DAL;
using Utility.Excel;
using Utility.Files;

namespace DebugUtility
{
    public partial class Frm_report : Form
    {
        public Frm_report()
        {
            InitializeComponent();
        }

        private void bind_DG_datasource()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = new UserService().getCustomerSets();
        }

        private void Frm_report_Load(object sender, EventArgs e)
        {
            //this.bind_DG_datasource();
        }

        private void Tsb_query_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new UserService().getCustmer();
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
    }
}
