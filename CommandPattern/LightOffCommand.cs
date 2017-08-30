using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class LightOffCommand : Command
    {
        private Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();        
        }
    }
}
