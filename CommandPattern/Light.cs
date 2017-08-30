using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        private OnOff onOff = 0;

        private enum OnOff
        {
            On = 1,
            Off = 0
        }

        public void on()
        {
            onOff = OnOff.On;
        }

        public void off()
        {
            onOff = OnOff.Off;
        }

    }
}
