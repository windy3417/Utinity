using SharpCifs.Smb;
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

        #region use smbclient library

        public bool ConnectTest(string ip, string user, string pwd)
        {
            SMB2Client client = new SMB2Client(); // SMB2Client can be used as well

            bool isConnected = client.Connect(IPAddress.Parse(ip), SMBTransportType.DirectTCPTransport);
            NTStatus status = client.Login(String.Empty, user, pwd);


            if (status == NTStatus.STATUS_SUCCESS)
            {

                client.Logoff();
                return true;
            }

            return false;

        }

        public List<string> GetDirectoryList(string ip, string user, string pwd)
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

        /// <summary>
        ///  bug in this method
        ///  it can not surpport hierarchy directory ,such as \\192.168.10.201\softeware\attachment\test.txt
        ///  only for two tier directory,such as \\192.168.10.201\softeware\test.txt
        ///  the way to fix bug
        ///   pay attention the specification of writing filepath
        /// right writing : subFold1\\subFould2\\test.tex
        /// false writing : \\subFold1\\subFould2\\test.tex
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="dir"></param>
        /// <param name="fileName"></param>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        public  MemoryStream GetFile(string ip, string shareName, string fileDir, string fileName, string user, string pwd)
        {
            SMB2Client client = new SMB2Client(); // SMB2Client can be used as well

            bool isConnected = client.Connect(IPAddress.Parse(ip), SMBTransportType.DirectTCPTransport);
            if (isConnected)
            {
                NTStatus status = client.Login(String.Empty, user, pwd);

                ISMBFileStore fileStore = client.TreeConnect(shareName, out status);
                object fileHandle;
                FileStatus fileStatus;
                string filePath = fileDir + "\\" + fileName;

                //SMB1FileStore not been modify to SMB2FielStore,or it occur error of invalid parametier,
                // so we can infer the fllowing statement is not necessary to be consistent with  the type of smbClient 
                if (fileStore is SMB1FileStore)
                {
                    filePath = @"\\"  + filePath ;
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



                    
                    }

                    status = fileStore.CloseFile(fileHandle);
                    status = fileStore.Disconnect();

                    return stream;

                   




                }

            }

            return null;


        }


        #endregion

        #region use cifs library

        public void ReadSmbFile(string ip, string dir, string fileName, string user, string pwd)
        {

            string address = $"smb://{user}:{pwd}@{ip}/{dir}/{fileName}";
            var file = new SmbFile(address);
            using (var readStream = file.GetInputStream())
            {

                FileStream fileStream = File.Create(Environment.CurrentDirectory + fileName);
               
                ((Stream)readStream).CopyTo(fileStream);
                fileStream.Close();
              
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + fileName);
            }
        }

        public void PutSmbFiles()
        {
            var file = new SmbFile("smb://UserName:Password@ServerIP/ShareName/Folder/NewFileName.txt");
            file.CreateNewFile();

            using (var writeStream = file.GetOutputStream())
            {
                writeStream.Write(Encoding.UTF8.GetBytes("Hello!"));
            }
        }


        #endregion


    }
}
