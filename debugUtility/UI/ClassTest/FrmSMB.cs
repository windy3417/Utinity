using SMBLibrary;
using SMBLibrary.Client;
using SMBLibrary.SMB1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpCifs.Smb;
using System.IO;
using System.Linq.Expressions;
using DebugUtility.Model;

namespace debugUtility.UI.ClassTest
{
    public partial class FrmSMB : Form
    {
        public FrmSMB()
        {
            InitializeComponent();
        }

        private void tsbExplore_Click(object sender, EventArgs e)
        {
           
            
            SMB1Client client = new SMB1Client(); // SMB2Client can be used as well
            bool isConnected = client.Connect(IPAddress.Parse("192.168.10.201"), SMBTransportType.DirectTCPTransport);
            NTStatus status = client.Login(String.Empty, "jing.luo@csximai.com", "ximai_2016");

            if (isConnected)
            {
                if (status == NTStatus.STATUS_SUCCESS)
                {
                    List<string> shares = client.ListShares(out status);

                    foreach (var item in shares)
                    {
                        richTextBox1.Text += item.ToString()+"  ";
                    }

                }
            }

            ISMBFileStore fileStore = client.TreeConnect("5S", out status);
            //if (status == NTStatus.STATUS_SUCCESS)
            //{
            //    object directoryHandle;
            //    FileStatus fileStatus;
               
            //    status = fileStore.CreateFile(out directoryHandle, out fileStatus,
            //        "\\", AccessMask.GENERIC_READ, FileAttributes.Directory,
            //        ShareAccess.Read | ShareAccess.Write, CreateDisposition.FILE_OPEN,
            //        CreateOptions.FILE_DIRECTORY_FILE, null);
            //    if (status == NTStatus.STATUS_SUCCESS)
            //    {
            //        List<FindInformation> fileList2;
            //        status = ((SMB1FileStore)fileStore).QueryDirectory(out fileList2, "\\*",
            //            FindInformationLevel.SMB_FIND_FILE_DIRECTORY_INFO);
            //        //status = fileStore.CloseFile(directoryHandle);
            //        foreach (var item in fileList2)
            //        {
            //            //richTextBox1.Text += item.;
            //        }
            //    }
            //}
            status = fileStore.Disconnect();


        }

        private void tsbDownload_Click(object sender, EventArgs e)
        {
            SMB2Client client = new SMB2Client(); // SMB2Client can be used as well

                        bool isConnected = client.Connect(IPAddress.Parse("192.168.10.201"), SMBTransportType.DirectTCPTransport);
            if (isConnected)
            {
                NTStatus status = client.Login(String.Empty, "jing.luo@csximai.com", "ximai_2016");

                ISMBFileStore fileStore = client.TreeConnect("software", out status);
                object fileHandle;
                FileStatus fileStatus;
                string filePath = "外发需返出厂单.pdf";
                if (fileStore is SMB1FileStore)
                {
                    filePath = @"\\" + filePath;
                }

                status = fileStore.CreateFile(out fileHandle, out fileStatus, filePath, AccessMask.GENERIC_READ | AccessMask.SYNCHRONIZE, SMBLibrary.FileAttributes.Normal,
                    ShareAccess.Read, CreateDisposition.FILE_OPEN, CreateOptions.FILE_NON_DIRECTORY_FILE | CreateOptions.FILE_SYNCHRONOUS_IO_ALERT, null);
                

                if (status == NTStatus.STATUS_SUCCESS)
                {
                    System.IO.MemoryStream stream = new System.IO.MemoryStream();
                    byte[] data;
                    long bytesRead = 0;
                    while (true)
                    {
                        status = fileStore.ReadFile(out data, fileHandle, bytesRead, (int)client.MaxReadSize);
                        if (status != NTStatus.STATUS_SUCCESS && status != NTStatus.STATUS_END_OF_FILE)
                        {
                            throw new Exception("Failed to read from file");
                        }

                        if (status == NTStatus.STATUS_END_OF_FILE || data.Length == 0)
                        {
                            break;
                        }
                        bytesRead += data.Length;
                        stream.Write(data, 0, data.Length);
                        FileStream fs = new FileStream(Environment.CurrentDirectory + filePath, FileMode.Create);
                        fs.Write(data, 0, data.Length);
                    }

                  

                  
                }

                MessageBox.Show("文件下载成功！");
                status = fileStore.CloseFile(fileHandle);
                status = fileStore.Disconnect();
            }
        }

        private void tsbRead_Click(object sender, EventArgs e)
        {
            try
            {
                //Get target's SmbFile.
                var file = new SmbFile("smb://jing.luo:ximai_2016@192.168.10.200/程序文件及体系证书/体系证书/新版体系证书/IATF16949：2016 证书  中英文版.pdf");

                //Get readable stream.
                var readStream = file.GetInputStream();

                //Create reading buffer.
                var memStream = new MemoryStream();

                FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory +file.GetName(), FileMode.Create);

                //Get bytes.
                ((Stream)readStream).CopyTo(fs);

                //Dispose readable stream.
                readStream.Dispose();
                MessageBox.Show("文件下载成功");
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }

            

            //Console.WriteLine(Encoding.UTF8.GetString(memStream.ToArray()));
            
        }

        private void tsbUpload_Click(object sender, EventArgs e)
        {
            //using System.Text;
            //using SharpCifs.Smb;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Get the SmbFile specifying the file name to be created.
            var file = new SmbFile("smb://jing.luo:ximai_2016@192.168.10.200/software/NewFileName.txt");

            //Create file.
            file.CreateNewFile();

            //Get writable stream.
            var writeStream = file.GetOutputStream();

            //Write bytes.
            writeStream.Write(Encoding.UTF8.GetBytes("Hello!"));

            //Dispose writable stream.
            writeStream.Dispose();
            MessageBox.Show("文件上传成功");

        }

        private void tsbReadExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ////Get target's SmbFile.
                //var file = new SmbFile("smb://jing.luo:ximai_2016@192.168.10.200/程序文件及体系证书/体系证书/新版体系证书/IATF16949：2016 证书  中英文版.pdf");

                ////Get readable stream.
                //var readStream = file.GetInputStream();

                ////Create reading buffer.
                //var memStream = new MemoryStream();

                //FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + file.GetName(), FileMode.Create);

                ////Get bytes.
                //((Stream)readStream).CopyTo(fs);

                ////Dispose readable stream.
                //readStream.Dispose();
                //MessageBox.Show("文件下载成功");

                int[,] cells = new int[,] { { 2, 1 },{ 3,1} };
                Utility.Excel.ReadCellsValue readCellsValue = new Utility.Excel.ReadCellsValue();
              //richTextBox1.Text
                List<string> cellsValue    =  readCellsValue.readExcelWithNPOI("E:\\CI GXMD202109037.xls", "1", "xls", cells);
                foreach (var item in cellsValue)
                {
                    richTextBox1.Text +=" " + item.ToString();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        private void tsbFileList_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            string directory = folderBrowserDialog.SelectedPath;
            Utility.Files.FileList fileList = new Utility.Files.FileList();
            ;
            foreach (var item in fileList.fileList(directory))
            {
                richTextBox1.Text += "  " + item;
            }
        }

        void ExpressionToString()
        {
            Expression<Func<Person, bool>> expression = s => s.FirstName == "windy";
            this.richTextBox1.Text = expression.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ExpressionToString();
        }
    }
}
