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
        /// <returns >返回删除文件数量</returns>
        public int  DeleteUserFile(string file_path)
        {

            int deleteFilesAmount=0;
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
                            if (extension == ".tmp" || extension == ".lnk")
                            {
                                File.Delete(file);
                                deleteFilesAmount++;

                            }

                        }
                    }
                    }

                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return deleteFilesAmount;  
           
            
           
        }

        /// <summary>
        /// 给定的文件夹下删除（包含嵌套文件夹里）指定扩展名的文件，
        /// 扩展名如.exe,.lib,.dll等
        /// /// </summary>
        /// <param name="file_path">文件路径</param>
        /// <param name="fileExtentionNameList" >文件扩展名</param>
        /// <returns >返回删除文件数量</returns>
        public int DeleteUserFile(string file_path,List<string> fileExtentionNameList)
        {

            int deleteFilesAmount = 0;
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
                            foreach (string item in fileExtentionNameList)
                            {
                                if (extension ==item )
                                {
                                    File.Delete(file);
                                    deleteFilesAmount++;

                                }
                            }
                           
                           

                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return deleteFilesAmount;



        }

    }
}
