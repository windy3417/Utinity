using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utility.Files
{
   public class JsonOperate
    {
        /// <summary>
        /// 实体转Json文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName">文件名</param>
        /// <param name="m">实体类型</param>
       public void ModelToJsonFile<T>(string fileName , T m)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;


            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, m);

            }
        }

        public T JsonToModel<T>(string fileName,T m)
        {
            
            if (File.Exists(fileName))
            {
                //读取本地json文件，为初始化外挂数据库提供信息

                JsonSerializer serializer = new JsonSerializer();
                // deserialize JSON directly from a file
                using (StreamReader sr = new StreamReader(fileName))
                {
                    return m= (T)serializer.Deserialize(sr, typeof(T));
                }


            }
            return m;
        }


    }
}
