using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_If_Else_Statements
{
    class BasicIfElse
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
                if (AIRSPEED > 100)
                {
                    Console.WriteLine($"Current IAS: {CurrentAirspeed}");
                    Console.WriteLine("IAS above minimum threshold for flaps. Please retract flaps to avoid structural damage");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Happy flying!");
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
