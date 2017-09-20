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
        int level;

        public Light(String location)
        {
            this.location = location;
        }

        public void on()
        {
            level = 100;
            Console.WriteLine("Light is on");
        }

        public void off()
        {
            level = 0;
            Console.WriteLine("Light is off");
        }

        public void dim(int level)
        {
            this.level = level;
            if (level == 0)
            {
                off();
            }
            else
            {
                Console.WriteLine("Light is dimmed to " + level + "%");
            }
        }

        public int getLevel()
        {
            return level;
        }
    }
}
