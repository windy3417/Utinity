using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
                            if (extension == ".tmp" || extension == ".lnk" || extension == ".txt" || extension == ".log")
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
                MessageBox.Show("文件删除错误：" + ex.Message + ex.InnerException, "文件删除提示");
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
                MessageBox.Show("文件删除错误：" + ex.Message + ex.InnerException, "文件删除提示");
            }

            return deleteFilesAmount;



        }

        //以json格式存储数据
        //文件名不存则增加，数据以追加的形式存储
        /// <summary>
        /// 以json格式存储数据
        /// </summary>
        ///<param name="fileName">数据文件名</param>
        ///<param name="model">模型数据</param>
        public void SaveDataInJson(string fileName, object model)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\" + fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, model);

            }

        }

        
        /// <summary>
        /// 读取以json格式存储的数据
        /// </summary>
        /// <param name="dataSourceType">数据源类型</param>
        /// <returns></returns>
        public object ReadDataFromJson<T>(string fileName)

        {
            string filePath = Environment.CurrentDirectory + "\\" + fileName;
           
            if (File.Exists(filePath))
            {
                //读取本地json文件，为初始化外挂数据库提供信息

                JsonSerializer serializer = new JsonSerializer();
                // deserialize JSON directly from a file
                using (StreamReader sr = new StreamReader(filePath))
                {
                    //因为方法中需要type类型，故引入泛型方法
                    return serializer.Deserialize(sr, typeof(T));
                                       
                }


            }
            return null;
        }

    }
}
