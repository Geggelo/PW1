using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

            switch (argument.ToUpper())
            {
                case "NO_LOG":
                    return;
                break;
                
                case "DELETE_LOG":
                    deleteLog(fileDir);
                break;

                case "VIEW_LOG":
                    viewLog(fileDir);
                break;

                default:
                    File.WriteAllText(fileDir,File.ReadAllText(fileDir) + DateTime.Now.ToString()+ "\n");
                break;
            }
            
        }

        static void deleteLog(string fileDir)
        {
            File.WriteAllText(fileDir,"");
        }
        static void viewLog(string fileDir)
        {
            File.WriteAllText(fileDir,File.ReadAllText(fileDir) + DateTime.Now.ToString()+ "\n");
            Process.Start(fileDir);
            
        }
    }
}
