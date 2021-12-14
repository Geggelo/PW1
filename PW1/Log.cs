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

            //Controllo se la directory è presente
            try
            {
                bool dir = (Directory.Exists(@"c:\itsd1")) ? true : false;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory di configurazione non trovata");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //Controllo se esiste log.txt
            if (!File.Exists(fileDir))
            {
                File.OpenWrite(fileDir).Close();
            }

            //Switch per gli input a console
            switch (argument.ToUpper())
            {
                case "NO_LOG":
                return;
                
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

        //Ripulire la log history
        static void deleteLog(string fileDir)
        {
            File.WriteAllText(fileDir,"");
        }

        //Aprire log.txt
        static void viewLog(string fileDir)
        {
            File.WriteAllText(fileDir,File.ReadAllText(fileDir) + DateTime.Now.ToString()+ "\n");
            Process.Start(fileDir);
        }
    }
}
