using System;
using System.Collections.Generic;
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
            if(args.Length!=0) Log.log(args[0]);
            else Log.log("");
            Console.ReadKey();
        }
    }
}
