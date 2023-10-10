using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_If_Else_Statements
{

    /*
     * This is quick if else statement practice to make sure it is staying with me over a few days.
     * Would need to add user input validation to make this a valid mini project.
     * I will work on validation going forward. Today learned a lot about revert git changes and changing startup project files.
     */

    class C_Ailerons
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please pick a direction to bank, type LEFT or RIGHT");
            string angleToBank = Console.ReadLine();

            while (true)
            {
                if (angleToBank == "left")
                {
                    Console.WriteLine("Left turn, Left aileron moves up, left wing moves down due to decrease in angle of attack. Right aileron angles down to increase angle of attack and raise the right wing.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Right turn, Right aileron moves up, right wing moves down due to decrease in angle of attack. Left aileron angles down to increase angle of attack and raise the left wing.");
                    Console.ReadLine();
                    break;
                }
            }
        }//end main
    }//end class
}//end namespace
