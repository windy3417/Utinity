using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode.Internal;

namespace DebugUtility.UI.ClassTest
{
    public partial class FrmPDF : Form
    {
        public FrmPDF()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    string dir = openFileDialog.FileName;
                    PdfDocument doc = new PdfDocument();
                    doc.LoadFromFile(dir);

                    StringBuilder buffer = new StringBuilder();
                    IList<Image> images = new List<Image>();

                    foreach (PdfPageBase page in doc.Pages)
                    {
                      
                        foreach (Image image in page.ExtractImages())
                        {
                            images.Add(image);
                            // create a barcode reader instance
                          
                            IBarcodeReader reader = new BarcodeReader();
                            // load a bitmap
                            var barcodeBitmap = (Bitmap)image;
                            // detect and decode the barcode inside the bitmap
                            var result = reader.Decode(barcodeBitmap);
                            // do something with the result
                            if (result != null)
                            {
                                dataGridView1.Rows[e.RowIndex].Cells[1].Value = result.BarcodeFormat.ToString();
                                dataGridView1.Rows[e.RowIndex].Cells[0].Value = result.Text;
                            }

                        }
                    }

                    doc.Close();

                 


                
            }
            }
        }
    }
}
