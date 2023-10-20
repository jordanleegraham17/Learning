using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class B_CountDown
    {
        /* This is a quick while loop practice - in this program I am trying to count backwards to the number 1 from a user defined number
         * if the user enters 50; we will count backwards from 50 until we reach 1
         */

        static void Main(String[] args)
        {
            Console.WriteLine("Please enter a value to countdown from:");// msg to start the program
            string userInput = Console.ReadLine(); // using a hardcoded entry number to start with - will make this user defined

            if (int.TryParse(userInput, out int currentValue))
            {
                while (currentValue > 1)
                {
                    currentValue--;//decrease the currentValue
                    Console.WriteLine(currentValue.ToString());//printing value were at to console
                }//end while loop
            }//end if validation for int input
            else
            {
                Console.WriteLine("Please enter a valid integer");
            }//end else
            Console.ReadKey();
        }// end main
    }//end class
}//end namespace
