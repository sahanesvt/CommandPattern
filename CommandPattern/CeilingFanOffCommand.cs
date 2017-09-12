using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFanOffCommand:Command
    {
        private string name = "CeilingFanOffCommand";

        public string getName()
        {
            return name;
        }

        private CeilingFan ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void execute()
        {
            ceilingFan.off();
        }

        
    }
}
