using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.lightBulb_start
{
    public class Remote
    {
        private LightBulb lightBulb;

        public Remote(LightBulb _lightBulb)
        {
            lightBulb = _lightBulb;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (lightBulb.IsOn())
            {
                lightBulb.TurnOff(); // Turn off the light if it's on
            }
            else
            {
                lightBulb.TurnOn(); // Turn on the light if it's off
            }
        }
    }
}
