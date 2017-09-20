﻿using System;
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

        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.off();
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
