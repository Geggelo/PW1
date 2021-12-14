using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Controllo se ho dato input da console
            if(args.Length!=0) Log.log(args[0]);
            else Log.log("");

            Licenza.check();
            Informazioni.inf();

            Console.ReadKey();
        }
    }
}
