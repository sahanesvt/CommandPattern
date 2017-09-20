﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StereoOnWithCDCommand:Command
    {
        private string name = "StereoWithCDCommand";

        public string getName()
        {
            return name;
        }

        private Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }

        public void undo()
        {
            stereo.off();
        }
    }
}
