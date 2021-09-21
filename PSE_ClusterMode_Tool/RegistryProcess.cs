using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectServerClusterMode
{
    public class RegistryProcess : values
    {
        public RegistryProcess()
        {

            bool control = true;
            while (control)
            {
                Console.WriteLine("**ProtectServer Cluster Mode**  \n 1- WLD \n 2 -HA \n 3- NORMAL");
                Console.Write("Please enter mode (1/2/3) : ");
                libMode = Console.ReadLine();

                try
                {
                    RegistryKey Location = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Safenet\PTKC", true);
                    RegistryKey newKey = Location.CreateSubKey("GENERAL", true);
                    newKey.SetValue($"ET_PTKC_GENERAL_LIBRARY_MODE", libMode);
                    control = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Value must be specified values... ", e.Message);
                    control = true;
                }
            }
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("\nSpecified Key Value Generated...\n");
            System.Threading.Thread.Sleep(2000);
        }
        public void addKeyValue()
        {
            Console.Write(" \nRefer to the link below about <ctkmu> ; \n https://thalesdocs.com/gphsm/ptk/5.9/docs/Content/PTK-C_Admin/CLI_Ref/CTKMU.htm \n ");

            bool control = true;
            while (control == true)
            {
                try
                {
                    Console.Write("\nPlease enter slot number as <ctkmu l> command output : ");

                    slotID = int.Parse(Console.ReadLine());

                    Console.Write("\nPlease enter slot NAME as <ctkmu l> command output :");

                    slotName = Console.ReadLine();

                    control = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Please enter correct value ...");
                    control = true;
                }
            }


            RegistryKey slotInfo = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Safenet\PTKC", true);
            RegistryKey slotKey = slotInfo.CreateSubKey("WLD", true);

            Console.WriteLine("The key value generating... \nResult : DONE");
            System.Threading.Thread.Sleep(2000);


            slotKey.SetValue($"ET_PTKC_WLD_SLOT_{slotID}", slotName);

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Cluster Mode Has Done. \nCommand Result : Success");

            Console.WriteLine("\nPress any key to exit ");
        }
    }
}
