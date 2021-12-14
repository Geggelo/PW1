using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace PW1
{
    internal static class Informazioni
    {
        public static void inf()
        {

            Console.WriteLine("Gruppo 7: Gabbatore e Moscato");
            Console.WriteLine("Path applicativo: "+ System.Reflection.Assembly.GetEntryAssembly().Location);
            Console.WriteLine("Sistema Operativo: " + System.Environment.OSVersion.Platform);
            Console.WriteLine("Versione: " + System.Environment.OSVersion);
            Console.WriteLine("drive: "+DriveInfo.GetDrives()[0]);
            Console.WriteLine("Spazio sul disco disponibile: "+new DriveInfo(DriveInfo.GetDrives()[0].ToString()).AvailableFreeSpace);
            Console.WriteLine("Hostname: "+Dns.GetHostName());
            foreach (var item in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                printVersionIP(item.ToString());
                Console.Write("IP ");
                Console.WriteLine(item);
            }

            //Get IP from URL
            string url = "www.itsincom.it";
            List<IPAddress> ip = new List<IPAddress>();
            
            try
            {
                foreach (var item in Dns.GetHostAddresses(url))
                {
                    ip.Add(item);
                }
            }
            catch (System.Net.Sockets.SocketException)
            {
                Console.WriteLine("Controllare connessione ad internet");
            }
            
            foreach (IPAddress id in ip)
            {
                Console.WriteLine("Host www.itsincom.it: {0}", id.ToString());
            }

            //Numero processi
            Process[] processes = Process.GetProcesses();
            Console.WriteLine("Numero processi attivi: {0}", processes.Length);

            //Processo con max id
            int max = processes[0].Id;
            string pName = processes[0].ToString();
            foreach (Process id in processes)
            {
                if (id.Id > max)
                {
                    max = id.Id;
                    pName = id.ToString();
                }
            }
            Console.WriteLine("Processo {0} con max id {1}", pName, max);

        }

        private static void printVersionIP(string ip)
        {
            Console.Write("Indirizzo ");
            IPAddress IP=IPAddress.Parse(ip);

            if(IP.AddressFamily.ToString()=="InterNetworkV6") Console.WriteLine("IPv6");
            else if(IP.AddressFamily.ToString()=="InterNetwork") Console.WriteLine("IPv4");

        }
    }
}
