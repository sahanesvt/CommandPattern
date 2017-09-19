using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TVOffCommand:Command
    {
        private string name = "TVOffCommand";

        public string getName()
        {
            return name;
        }

        private TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.off();
        }

        public void undo()
        {
            tv.on();
        }
    }
}
