using SharpCifs.Smb;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.Files
{
  public  class CifsFiles
    {
        public void TestConnect()
        {
            SharpCifs.Config.SetProperty("jcifs.smb.client.lport", "8137");

            //string to Auth-Object.
            var auth1 = new NtlmPasswordAuthentication("UserName:Password");
            var smb1 = new SmbFile("smb://192.168.0.1/ShareName/FolderName/", auth1);
            Console.WriteLine($"exists? {smb1.Exists()}");
        }

        public void GetFile(string credential,string dir,string fileName)
        {
            try
            {

                FolderBrowserDialog folder = new FolderBrowserDialog();
                
                string smbDir = credential + dir + fileName;
                //Get target's SmbFile.
                var file = new SmbFile(smbDir);

                //Get readable stream.
                var readStream = file.GetInputStream();

                //Create reading buffer.
                var memStream = new MemoryStream();

                FileStream fs = new FileStream(folder.SelectedPath + file.GetName(), FileMode.Create);

                //Get bytes.
                ((Stream)readStream).CopyTo(fs);

                //Dispose readable stream.
                readStream.Dispose();
                MessageBox.Show("文件下载成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }


    }
}
