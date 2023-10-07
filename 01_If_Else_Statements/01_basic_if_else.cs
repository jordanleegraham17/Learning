using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_If_Else_Statements
{
    class AirspeedIndicator
    {
        static void Main()
        {

            // for practice on if else statements I am going to replicate the various meanings of the markings on an Airspeed Indicator of a Cessna 152
            String greetingMessage = "Welcome to your Cessna 152 speed checker, please enter your current airspeed:";
            Console.WriteLine(greetingMessage); // trying out this way of writing strings to the console, feels pointless to save a string as that, does it effect memory?

            String CurrentAirspeed = Console.ReadLine();

            // validate the input as a int
            if (int.TryParse(CurrentAirspeed, out int AIRSPEED))
            {
                if (AIRSPEED >= 160)
                {
                    Console.WriteLine($"Current IAS: {CurrentAirspeed}");
                    Console.WriteLine("IAS at Never Exceed Speed (VNE)");
                    Console.ReadLine();
                }
                else if (AIRSPEED == 120)
                {
                    Console.WriteLine($"Current IAS: {CurrentAirspeed}");
                    Console.WriteLine("Maximum Structural Cruising Speed (VNO)");
                    Console.ReadLine();
                }
                else if (AIRSPEED > 120 && AIRSPEED < 160)
                {
                    Console.WriteLine($"Current IAS: {CurrentAirspeed}");
                    Console.WriteLine("Yellow Arc; Smooth air operating range (from VNO to VNE)");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Current IAS: {CurrentAirspeed}");
                    Console.WriteLine("Green Arc: Normal operating speed range (from VSI to VNO); Happy flying!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Write("Please enter an integer value for airspeeds.");
            }
        }
    }
}
