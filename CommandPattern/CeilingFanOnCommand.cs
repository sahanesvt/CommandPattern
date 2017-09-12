using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFanOnCommand:Command
    {
        private string name = "CeilingFanOnCommand";

        public string getName()
        {
            return name;
        }

        private CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void execute()
        {
            ceilingFan.high();
        }
    }
}
