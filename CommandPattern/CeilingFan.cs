using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFan
    {
        String location = "";
        int level;
        public static readonly int HIGH = 2;
        public static readonly int MEDIUM = 1;
        public static readonly int LOW = 0;

        public CeilingFan(String location)
        {
            this.location = location;
        }

        public void high()
        {
            // turns the ceiling fan on to high
            level = HIGH;
            Console.WriteLine(location + " ceiling fan is on high");

        }

        public void medium()
        {
            // turns the ceiling fan on to medium
            level = MEDIUM;
            Console.WriteLine(location + " ceiling fan is on medium");
        }

        public void low()
        {
            // turns the ceiling fan on to low
            level = LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void off()
        {
            // turns the ceiling fan off
            level = 0;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public int getSpeed()
        {
            return level;
        }
    }
}
