using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoorUpCommand:Command
    {
        private string name = "GarageDoorUpCommand";

        public string getName()
        {
            return name;
        }

        private GarageDoor garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
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
