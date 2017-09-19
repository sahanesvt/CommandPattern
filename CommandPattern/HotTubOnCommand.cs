using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class HotTubOnCommand:Command
    {
        private string name = "HotTubOnCommand";

        public string getName()
        {
            return name;
        }

        private HotTub hotTub;

        public HotTubOnCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }

        public void execute()
        {
            hotTub.on();
        }

        public void undo()
        {
            hotTub.off();
        }
    }
}
