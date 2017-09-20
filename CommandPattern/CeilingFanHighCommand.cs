using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFanHighCommand
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.high();
        }
        public void undo()
        {
            switch (prevSpeed)
            {
                case CeilingFan.HIGH: ceilingFan.high(); break;
                case CeilingFan.MEDIUM: ceilingFan.medium(); break;
                case CeilingFan.LOW: ceilingFan.low(); break;
                default: ceilingFan.off(); break;
            }
        }
    }
}
