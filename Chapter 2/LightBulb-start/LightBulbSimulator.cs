using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2.LightBulb_start
{
    public class LightBulbSimulator
    {
        public static void main(string[] args)
        {
            LightBulb lightBulb = new LightBulb();
            Remote remote = new Remote(lightBulb);

            Console.WriteLine("Turning the light bulb on...");
            remote.PressButton();

            Console.WriteLine("\nTurning the light bulb off...");
            remote.PressButton();

            Console.WriteLine("\nTurning the light bulb on again...");
            remote.PressButton();

            Console.WriteLine("\nTurning the light bulb off again...");
            remote.PressButton();
        }
    }
}
