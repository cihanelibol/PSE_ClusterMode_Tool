
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectServerClusterMode
{
    class Program
    {
        static void Main(string[] args)
        {



            RegistryProcess general = new RegistryProcess();

            general.addKeyValue();

            Console.ReadLine();



        }
    }
}
