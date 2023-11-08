using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ABOUT
 * The purpose of this class will be to demonstrate the basics of switch statements.
 * Also included is a quick overview of a 'ternary operator'.
 * This class won't include much or any inputs or input validation and will act as a quick reference 
 * to a working switch statement and ternary operator so the syntax can be quickly revised.
 */

namespace _04_SwitchStatements
{
    class A_SwitchFundamentals
    {
        static void Main(String[] args)
        {
            //variables
            int indicatedAirSpeed = 54;
            
            //ternary operator example
            bool canFly = indicatedAirSpeed >= 50 ? true : false;

            //testing ternary operator
            Console.WriteLine($"Current IAS: {indicatedAirSpeed}, can we lift off : {canFly}");
            Console.ReadKey();//keeping the terminal alive

        }//end main
    }//end class
}//end namespace
