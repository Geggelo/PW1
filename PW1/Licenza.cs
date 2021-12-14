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
            string fileDir = @"c:\itsd1\config.ini";
            string text = File.ReadAllText(fileDir);
            char[] cut = new char[] { '=' };
            string[] text1 = text.Split(cut);
            var now = DateTime.Now;
            
            try
            {
                //Conversione data da config.ini 
                var date = DateTime.Parse(text1[1]);
                //Controllo se esiste config.ini
                bool file = (File.Exists(fileDir)) ? true : false;
                //Controllo se il parametro esiste
                bool var = (text1[0] == "DATA_SCADENZA") ? true : false;
                if (var == false)
                {
                    Console.WriteLine("Data scadenza non presente");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                //Controllo se la licenza è scaduta
                bool valid = (date > now) ? true : false;
                if (valid == false)
                {
                    Console.WriteLine("Licenza scaduta");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
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
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Data scadenza non presente");
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
