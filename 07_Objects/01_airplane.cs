using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Objects
{
    class Airplane
    {
        int aircraftId;
        string airlineName;
        string airlineCallsign;
        string aircraftType;
        int maxSpeed;

        public static void Main(String[] args)
        {
            // create new instance of the Airplane object
            Airplane AerLingus = new()
            {
                // add values to the airplane properties required for this object (id, name, callsign, type)
                aircraftId = 1,
                airlineName = "Aer Lingus",
                airlineCallsign = "Shamrock",
                aircraftType = "Airbus A320",
                maxSpeed = 903
            };

            // output this objects values to the console
            Console.WriteLine(AerLingus.aircraftId);
            Console.WriteLine(AerLingus.airlineName);
            Console.WriteLine(AerLingus.airlineCallsign);
            Console.WriteLine(AerLingus.aircraftType);
            Console.WriteLine(AerLingus.maxSpeed);


            // ____ attempting new way of declaring object ____
            Airplane Ryanair = new() 
            { 
                aircraftId = 2, 
                airlineName = "Ryanair", 
                airlineCallsign = "Ryanair", 
                aircraftType = "737-Max", 
                maxSpeed = 839
            };

            // output this objects values to the console
            Console.WriteLine(Ryanair.aircraftId);
            Console.WriteLine(Ryanair.airlineName);
            Console.WriteLine(Ryanair.airlineCallsign);
            Console.WriteLine(Ryanair.aircraftType);
            Console.WriteLine(Ryanair.maxSpeed);

            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
