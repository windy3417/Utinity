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
            bool isConnected = client.Connect(IPAddress.Parse("192.168.10.200"), SMBTransportType.DirectTCPTransport);
            NTStatus status = client.Login(String.Empty, "jing.luo", "ximai_2016");

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
            if (status == NTStatus.STATUS_SUCCESS)
            {
                object directoryHandle;
                FileStatus fileStatus;
               
                status = fileStore.CreateFile(out directoryHandle, out fileStatus,
                    "\\", AccessMask.GENERIC_READ, FileAttributes.Directory,
                    ShareAccess.Read | ShareAccess.Write, CreateDisposition.FILE_OPEN,
                    CreateOptions.FILE_DIRECTORY_FILE, null);
                if (status == NTStatus.STATUS_SUCCESS)
                {
                    List<FindInformation> fileList2;
                    status = ((SMB1FileStore)fileStore).QueryDirectory(out fileList2, "\\*",
                        FindInformationLevel.SMB_FIND_FILE_DIRECTORY_INFO);
                    //status = fileStore.CloseFile(directoryHandle);
                    foreach (var item in fileList2)
                    {
                        //richTextBox1.Text += item.;
                    }
                }
            }
            status = fileStore.Disconnect();


        }
    }
}
