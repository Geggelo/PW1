using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1
{
    internal static class Licenza
    {
        public static void check()
        {
            try
            {
                string text = File.ReadAllText(@"c:\itsd1\config.ini");
                char[] cut = new char[] { '=' };
                string[] text1 = text.Split(cut);
                var now = DateTime.Now;
                var date = DateTime.Parse(text1[1]);

                bool dir = (Directory.Exists(@"c:\itsd1")) ? true : false;
                bool file = (File.Exists(@"c:\itsd1\config.ini")) ? true : false;
                bool var = (text1[0] == "DATA_SCADENZA") ? true : false;
                if (var == false)
                {
                    Console.WriteLine("Data scadenza non presente");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                bool valid = (date > now) ? true : false;
                if (valid == false)
                {
                    Console.WriteLine("Licenza scaduta");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory di configurazione non trovata");
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File di configurazione non presente");
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Errore nel file di configurazione");
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }


    }
}
