using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class HotTub
    {
        public void on()
        {
            Console.WriteLine("Hottub is heating to a steaming 104 degrees \nHottub is bubbling!");
        }

        public void off()
        {
            Console.WriteLine("Hottub is cooling to 98 degrees");
        }
    }
}
