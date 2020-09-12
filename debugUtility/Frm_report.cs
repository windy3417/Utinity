using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DebugUtility.DAL;

namespace DebugUtility
{
    public partial class Frm_report : Form
    {
        public Frm_report()
        {
            InitializeComponent();
        }

        private  void bind_DG_datasource()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = new CustomerService().getCustomerSets();
        }

        private void Frm_report_Load(object sender, EventArgs e)
        {
            this.bind_DG_datasource();
        }
    }
}
