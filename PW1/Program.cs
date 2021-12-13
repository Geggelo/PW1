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
            if (args.Length == 0) 
            {
                    ProcessStartInfo startInfo = new ProcessStartInfo("PW1.exe");
                    startInfo.UseShellExecute=false;
                    startInfo.Arguments = "NO_LOG";
                    Process.Start(startInfo);
            }
            Log.log();
            Console.ReadKey();
        }
    }
}
