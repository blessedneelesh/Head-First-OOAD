using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2.LightBulb_start
{
    public class LightBulb
    {
        private bool isOn;

        public LightBulb()
        {
            isOn = false;
        }

        public void TurnOn()
        {
            Console.WriteLine("The light bulb is on.");
            isOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("The light bulb is off.");
            isOn = false;
        }

        public bool IsOn()
        {
            return isOn;
        }
    }
}
