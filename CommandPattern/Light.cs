using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        /*private OnOff onOff;

        private enum OnOff
        {
            On = 1,
            Off = 0
        }

        public void on()
        {
            onOff = OnOff.On;
        }

        public void off()
        {
            onOff = OnOff.Off;
        }*/

        String location;
        public Light(String location)
        {
            this.location = location;
        }

        public void on()
        {
            Console.WriteLine(location + " light is on");
        }

        public void off()
        {
            Console.WriteLine(location + " light is off");
        }
    }
}
