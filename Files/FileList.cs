using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utility.Model;

namespace Utility.Files
{
  public  class FileList
    {
        public List<FileInfoModel> fileList(string directory)
        {
           
            List<FileInfoModel> fileInfo = new List<FileInfoModel>();
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            FileSystemInfo[] fileSystemInfo = directoryInfo.GetFileSystemInfos();
            foreach (var item in fileSystemInfo)
            {

                FileInfoModel m = new FileInfoModel();
                m.fileName = item.FullName;
                m.extentName=item.Extension;
                fileInfo.Add(m);
            }

            return fileInfo;
        }
    }
}
