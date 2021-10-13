using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utility.Files
{
  public  class FileList
    {
        public List<string> fileList(string directory)
        {
            List<string> filesName = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            FileSystemInfo[] fileSystemInfo = directoryInfo.GetFileSystemInfos();
            foreach (var item in fileSystemInfo)
            {
                filesName.Add(item.FullName);
            }

            return filesName;
        }
    }
}
