using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.Files
{
  public  class FilesOperate
    {
        /// <summary>
        /// 删除文件夹下（包含嵌套文件夹里），所有.exe,.lib,.dll文件
        /// </summary>
        /// <param name="file_path">文件路径</param>
        public void DeleteUserFile(string file_path)
        {
            try
            {
                foreach (string file in Directory.GetFileSystemEntries(file_path))
                {
                    if (Directory.Exists(file))
                    {
                        DeleteUserFile(file);
                    }
                    else
                    {
                        if (File.Exists(file))
                        {
                            string extension = System.IO.Path.GetExtension(file);
                            //if (extension == ".tmp" || extension == ".lib" || extension == ".dll")
                            if (extension == ".tmp")
                            {
                                File.Delete(file);
                               
                            }
                            MessageBox.Show("文件删除成功", "删除提示");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
