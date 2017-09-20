using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoorDownCommand:Command
    {
        private string name = "GarageDoorDownCommand";

        public string getName()
        {
            return name;
        }

        public GarageDoor garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.up();
        }

        public void undo()
        {
            garageDoor.down();
        }
    }
}
