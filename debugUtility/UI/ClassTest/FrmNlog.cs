using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugUtility.UI.ClassTest
{
    public partial class FrmNlog : Form
    {
        public FrmNlog()
        {
            InitializeComponent();
        }

        private void tsbWriteLog_Click(object sender, EventArgs e)
        {
            NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
            try
            {
                Logger.Info("Hello world");
                //Logger.Info()
                System.Console.ReadKey();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Goodbye cruel world");
            }
        }
    }
}
