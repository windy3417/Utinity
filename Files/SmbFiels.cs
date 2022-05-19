using SMBLibrary;
using SMBLibrary.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Utility.Files
{
  public  class SmbFiels
    {
        public bool ConnectTest(string ip, string user, string pwd)
        {
            SMB1Client client = new SMB1Client(); // SMB2Client can be used as well
            bool isConnected = client.Connect(IPAddress.Parse(ip), SMBTransportType.DirectTCPTransport);
            NTStatus status = client.Login(String.Empty, user, pwd);
            
          
            if (status == NTStatus.STATUS_SUCCESS)
            {
                
                client.Logoff();
                return true;
            }

            return false;

        }

        public List<string> GetDirectoryList(string ip,string user,string pwd)
        {
            SMB1Client client = new SMB1Client(); // SMB2Client can be used as well
            bool isConnected = client.Connect(IPAddress.Parse(ip), SMBTransportType.DirectTCPTransport);
            NTStatus status = client.Login(String.Empty, user, pwd);

            if (isConnected)
            {
                if (status == NTStatus.STATUS_SUCCESS)
                {
                    List<string> shares = client.ListShares(out status);

                    return shares;

                   
                }

                return null;
            }

            return null;
        }

        public void GetFile(string ip, string dir, string fileName, string user, string pwd)
        {
            SMB2Client client = new SMB2Client(); // SMB2Client can be used as well

            bool isConnected = client.Connect(IPAddress.Parse(ip), SMBTransportType.DirectTCPTransport);
            if (isConnected)
            {
                NTStatus status = client.Login(String.Empty, user, pwd);

                ISMBFileStore fileStore = client.TreeConnect(dir, out status);
                object fileHandle;
                FileStatus fileStatus;
                string filePath = fileName;
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
    }
}
