using SMBLibrary;
using SMBLibrary.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DebugUtility.Common

{
    class SMBclient
    {
      
        public  void readSmbFile()
        {
            SMB1Client client = new SMB1Client(); // SMB2Client can be used as well
         

        bool isConnected = client.Connect(IPAddress.Parse("192.168.10.200"), SMBTransportType.DirectTCPTransport);
            if (isConnected)
            {
                NTStatus status = client.Login(String.Empty, "jing.luo", "ximai_2016");

                ISMBFileStore fileStore = client.TreeConnect("software", out status);
                object fileHandle;
                FileStatus fileStatus;
                string filePath = "EXCEL在财务管理中的高级应用.pdf";
                if (fileStore is SMB1FileStore)
                {
                    filePath = @"\\" + filePath;
                }
                status = fileStore.CreateFile(out fileHandle, out fileStatus, filePath, AccessMask.GENERIC_READ | AccessMask.SYNCHRONIZE,
                    (SMBLibrary.FileAttributes)System.IO.FileAttributes.Normal, ShareAccess.Read, CreateDisposition.FILE_OPEN,
                    CreateOptions.FILE_NON_DIRECTORY_FILE | CreateOptions.FILE_SYNCHRONOUS_IO_ALERT, null);

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
                    }
                }
                status = fileStore.CloseFile(fileHandle);
                status = fileStore.Disconnect();
            }

            //if (status == NTStatus.STATUS_SUCCESS)
            //{
            //    List<string> shares = client.ListShares(out status);
            //    client.Logoff();
            //}
            //client.Disconnect();
        }

           
    }
        
        
      
}
