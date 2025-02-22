using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Timer = System.Timers.Timer;


namespace Chapter_3.lightBulb_detector
{
    public class Remote
    {
        private LightBulb lightBulb;
        Timer checkForTime = new Timer();

        public Remote(LightBulb _lightBulb)
        {
            lightBulb = _lightBulb;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (lightBulb.IsOn())
            {
                lightBulb.TurnOff();
            }
            else
            {
                lightBulb.TurnOn();
                checkForTime.Interval = 5000; // 5 seconds
                checkForTime.Elapsed += Run;
                checkForTime.AutoReset = false;
                checkForTime.Start();
            }
        }

        private void Run(object sender, ElapsedEventArgs e)
        {
            checkForTime.Stop();
            lightBulb.TurnOff();
        }
    }
}
