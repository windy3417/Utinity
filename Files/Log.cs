using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utility.Files
{
   public static class Log
    {
    public static void  WriteDebugLog(string log)
        {
            File.AppendAllText("C:\\Windows\\Temp\\debug.txt", log);
        }
    }
}
