using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class HotTubOffCommand:Command
    {
        private string name = "HotTubOffCommand";

        public string getName()
        {
            return name;
        }

        private HotTub hotTub;

        public HotTubOffCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }

        public void execute()
        {
            hotTub.off();
        }

        public void undo()
        {
            hotTub.on();
        }
    }
}
