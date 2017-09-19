using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TVOnCommand: Command
    {
        private string name = "TVOnCommand";

        public string getName()
        {
            return name;
        }

        private TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.on();
        }

        public void undo()
        {
            tv.off();
        }
    }
}
