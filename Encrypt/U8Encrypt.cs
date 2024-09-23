using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Encrypt
{
    /// <summary>
    /// the encrypt method for u8
    /// </summary>
    public class U8Encrypt
    {
        public static string U8Password(string password)
        {
            //加密后，最后一个特殊字符：Unicode编码
            string lastChar = "\u0003";
            //密码转换为加密字符串
            byte[] src = Encoding.Default.GetBytes(password);
            string dst = Convert.ToBase64String(SHA1.Create().ComputeHash(src)) + lastChar;
            return dst;
        }
    }
}
