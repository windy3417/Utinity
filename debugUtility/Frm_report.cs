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
    }
}
