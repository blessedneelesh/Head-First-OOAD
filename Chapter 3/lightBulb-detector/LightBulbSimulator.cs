using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3.lightBulb_detector
{
        public class LightBulbSimulator
        {
            public static void main(string[] args)
            {
                LightBulb lightBulb = new LightBulb();
                MotionDetector detector = new MotionDetector(lightBulb);
                Remote remote = new Remote(lightBulb);

                Console.WriteLine("Motion detected...");
                detector.DetectMotion();

                Console.WriteLine("\nWaiting for motion to stop...");
                Thread.Sleep(5000); // Simulate waiting for motion to stop

                Console.WriteLine("\nNo motion detected, turning off the light bulb...");
                remote.PressButton();

                Console.WriteLine("\nMotion detected again...");
                detector.DetectMotion();

                Console.WriteLine("\nWaiting for motion to stop...");
                Thread.Sleep(5000); // Simulate waiting for motion to stop

                Console.WriteLine("\nNo motion detected, turning off the light bulb...");
                remote.PressButton();
            }
        }
    }
