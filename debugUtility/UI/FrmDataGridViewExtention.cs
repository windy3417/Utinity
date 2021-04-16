using debugUtility.Common;
using debugUtility.Modle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugUtility.UI
{
    public partial class FrmDataGridViewExtention : Form
    {
        public FrmDataGridViewExtention()
        {
            InitializeComponent();
        }

        private void FrmDataGridViewExtention_Load(object sender, EventArgs e)
        {
            var list = new List<Person>()
    {
        new Person()
        {
            Id= 1, FirstName= "Mario", LastName= "Speedwagon",
            BirthDate = DateTime.Now.AddYears(-30).AddMonths(2).AddDays(5),
            IsMember = true, Url ="https://Mario.example.com"
        },
        new Person()
        {
            Id= 1, FirstName= "Petey", LastName= "Cruiser",
            BirthDate = DateTime.Now.AddYears(-20).AddMonths(5).AddDays(1),
            IsMember = false, Url ="https://Petey.example.com"
        },
        new Person()
        {
            Id= 1, FirstName= "Anna", LastName= "Sthesia",
            BirthDate = DateTime.Now.AddYears(-40).AddMonths(3).AddDays(8),
            IsMember = true, Url ="https://Anna.example.com"
        },
    };

            this.dgvExtention.Bind(list, true);
        }
    }
}
