using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectServerClusterMode
{
    public class values
    {
        public int slotID { get; set; }
        public string slotName { get; set; }

        private string _libMode;
        public string libMode
        {
            get { return _libMode; }

            set
            {
                if (value == "1" || value == "2" || value == "3")
                {

                    this._libMode = libModeCheck(value);
                }
                else
                {
                    Console.WriteLine("Please check value...");
                }

            }
        }
        private string libModeCheck(string value)
        {
            switch (value)
            {
                case "1":
                    return value = "WLD";

                case "2":
                    return value = "HA";

                case "3":
                    return value = "NORMAL";

                default:
                    Console.WriteLine("Value is checking...");
                    return value;

            }
        }


    }
}
