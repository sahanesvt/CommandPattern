using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StereoOffCommand:Command
    {
        private string name = "StereoOffCommand";

        public string getName()
        {
            return name;
        }

        private Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }
    }
}
