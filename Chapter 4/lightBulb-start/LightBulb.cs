using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Chapter_4.lightBulb_start
{
    public class LightBulb
    {
        private bool isOn;
        Timer timer = new Timer(5000); // Timer to automatically turn off the light after 5 seconds

        public LightBulb()
        {
            isOn = false;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = false; // Ensure the timer only runs once
        }

        public void TurnOn()
        {
            Console.WriteLine("The light bulb is on.");
            isOn = true;
            timer.Start(); // Start the timer when the light is turned on
        }

        public void TurnOff()
        {
            Console.WriteLine("The light bulb is off.");
            isOn = false;
            timer.Stop(); // Stop the timer when the light is turned off
        }

        public bool IsOn()
        {
            return isOn;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (isOn)
            {
                TurnOff(); // Automatically turn off the light after the timer elapses
            }
        }
    }
}
