using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoor
    {
        private String location;

        public GarageDoor(String location)
        {
            this.location = location;
        }

        public void up()
        {
            Console.WriteLine(location + " garage Door is Up");
        }

        public void down()
        {
            Console.WriteLine(location + " garage Door is Down");
        }

        public void stop()
        {
            Console.WriteLine(location + " garage Door is Stopped");
        }

        public void lightOn()
        {
            Console.WriteLine(location + " garage light is on");
        }

        public void lightOff()
        {
            Console.WriteLine(location + " garage light is off");
        }
    }
}
