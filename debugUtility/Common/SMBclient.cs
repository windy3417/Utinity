using SharpCifs.Smb;
using SMBLibrary;
using SMBLibrary.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DebugUtility.Common

{
    class SMBclient
    {

        public void ReadSmbFile()
        {
            var file = new SmbFile("smb://UserName:Password@ServerIP/ShareName/Folder/FileName.txt");
            using (var readStream = file.GetInputStream())
            {
                var memStream = new MemoryStream();
                ((Stream)readStream).CopyTo(memStream);
                Console.WriteLine(Encoding.UTF8.GetString(memStream.ToArray()));
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




    }
}
