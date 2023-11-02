using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This class is to practice reversing a string. 
 * the plan is to use a for loop to reverse a hardcoded string.
 */

namespace _04_Loops
{
    class F_ReverseString
    {
        static void Main(String[] args)
        {
            //printing out a string to reverse
            string stringToReverse = "Reverse This String Please";

            //print that string to console
            Console.WriteLine(stringToReverse);

            //count the numer of values in the string - show to console
            Console.WriteLine($"The lenght of the string is: {stringToReverse.Length}");

            //check can we loop through each value in the string
            for (int i = 0; i < stringToReverse.Length; i++) 
            {
                Console.WriteLine(stringToReverse[i]);
            }//end for loop

            Console.ReadKey();


        }//end main
    }//end class
}//end namesoace
