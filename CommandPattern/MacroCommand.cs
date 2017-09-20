using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MacroCommand:Command
    {
        private Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void execute()
        {
            foreach (Command command in commands)
            {
                command.execute();
            }
        }

        public void undo()
        {
            for (int i = commands.Length -1; i == 0; i--)
            {
                commands[i].undo();
            }
        }

        public string getName() { return "Macro Command"; }
    }
}
