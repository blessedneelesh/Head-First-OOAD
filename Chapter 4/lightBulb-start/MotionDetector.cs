using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.lightBulb_start
{
    public class MotionDetector
    {
        private LightBulb lightBulb;

        public MotionDetector(LightBulb _lightBulb)
        {
            lightBulb = _lightBulb;
        }

        public void DetectMotion()
        {
            Console.WriteLine("MotionDetector: Motion detected!");
            lightBulb.TurnOn(); // Turn on the light when motion is detected
        }
    }
}
