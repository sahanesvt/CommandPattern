using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        String location;
        int speed;

        public CeilingFan(String location)
        {
            this.location = location;
        }

        public void high()
        {
            // turns the ceiling fan on to high
            speed = HIGH;
            Console.WriteLine(location + " ceiling fan is on high");
        }

        public void medium()
        {
            // turns the ceiling fan on to medium
            speed = MEDIUM;
            Console.WriteLine(location + " ceiling fan is on medium");
        }

        public void low()
        {
            // turns the ceiling fan on to low
            speed = LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void off()
        {
            // turns the ceiling fan off
            speed = OFF;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public int getSpeed()
        {
            return speed;
        }
    }
}
