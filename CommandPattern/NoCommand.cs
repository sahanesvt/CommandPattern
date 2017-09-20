using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class NoCommand : Command
    {
        public void execute()
        {
        }
        
        public void undo()
        {
        }

        public string getName() { return "No Command"; }
    }
}
