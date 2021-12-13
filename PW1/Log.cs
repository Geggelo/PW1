using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1
{
    internal static class Log
    {
        public static void log(string argument)
        {
            string fileDir = @"c:\itsd1\log.txt";
            string dir = @"c:\itsd1";

            if (!Directory.Exists(dir))
            {
                Console.WriteLine("la cartella non esiste");
                return;
            }

            if (!File.Exists(fileDir))
            {
                File.OpenWrite(fileDir).Close();
            }

            //File.WriteAllText(fileDir,File.ReadAllText(fileDir) + DateTime.Now.ToString()+ "\n");
            viewLog(fileDir);
            
        }

        static void deleteLog()
        {
            //File.WriteAllText("");
        }
        static void viewLog(string fileDir)
        {
            File.WriteAllText(fileDir,File.ReadAllText(fileDir) + DateTime.Now.ToString()+ "\n");
            
            
        }
    }
}
