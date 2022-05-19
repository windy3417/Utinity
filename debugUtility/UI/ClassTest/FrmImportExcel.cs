﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Excel;

namespace debugUtility.UI
{
    public partial class FrmImportExcel : Form
    {
        public FrmImportExcel()
        {
            InitializeComponent();
        }

        private void tspImport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            ImportFromExcel importFromExcel = new ImportFromExcel();
            importFromExcel.ReadExcelWithNPOI(this.dataGridView1, dataTable);
        }
    }
}
