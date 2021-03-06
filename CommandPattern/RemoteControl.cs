﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        private Command[] onCommands;
        private Command[] offCommands;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, Command onCommand,Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
        }

        public string toString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control ------\n");
            for(int i =0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot " + i + "] " + onCommands[i].getName() + "      " + offCommands[i].getName()+"\n");
            }
            return stringBuff.ToString();
        }
    }
}
