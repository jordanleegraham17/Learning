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
            int currentValue = 20; // using a hardcoded entry number to start with - will make this user defined later
            
            while (currentValue >= 1)
            {
                currentValue--;
                Console.WriteLine(currentValue.ToString());
            }
            Console.ReadKey();
        }// end main
    }//end class
}//end namespace
