using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ABOUT
 * the purpose of this class is to take in a user entered value,
 * validate it is an integer value, if not ask again,
 * convert the value in minutes - to seconds.
 * output the result to the user. 
 * This should all be done as a function
 */

namespace _06_BasicFunctions
{
    class E_minutesConverter
    {
        public static void Main(String[] args )
        {
            //prompt the user for a correct input and validate.
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Please enter a MINUTES value to convert into seconds: ");

                //validate user input
                int minutesValue;
                if (int.TryParse(Console.ReadLine(), out minutesValue))
                {
                    convertMinutes( minutesValue );
                }//end if
                else
                {
                    Console.WriteLine("Try again and please enter a valid integer value");
                }//end else
            }//end while
        }//end main

        //_______FUNCTIONS_______
        static void convertMinutes(int minutesValue)
        {
            Console.WriteLine($"\nYour minutes value to convert is: {minutesValue}");
            int secondsValue = minutesValue * 60; //basic logic

            Console.WriteLine($"Your seconds value is: {secondsValue}"); //output to user , program then restarts
        }//end convertMinutes() method
    }//end class
}//end namespace
