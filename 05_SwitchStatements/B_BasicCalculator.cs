using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchStatements
{
    class B_BasicCalculator
    {
        /* the purpose of this class will be to practice switch statements
         * this will be done by recreating an earlier project 'MathGame.cs' in the 03_IfElseStatements section
         * this time the code will be made more efficient by practicing and using a switch statement for the
         * operation choice of the user.
         */

        static void Main(string[] args)
        {
            String greetingMessage = "Welcome to the basic calculator. In this program, the user will select two values " +
                                     "and then an operation they would like to perform on these values i.e. " +
                                     "Addition, Subtraction, Multiplcation and Division. " +
                                     "The purpose of this program is to practice switch statements in the background!";

            int firstValue, secondValue; // require these values for the calculations
            bool isValidInteger = false; // will use in a while loop to keep asking user for integer if they enter elsewise

            Console.WriteLine($"{greetingMessage}");

            // while loop to prompt the user for the firstValue
            while ( !isValidInteger )
            {
                Console.WriteLine("\nPlease enter your first value:");
                if ( int.TryParse(Console.ReadLine(), out firstValue ))
                {
                    Console.WriteLine($"Your value is: {firstValue}");

                    Console.WriteLine("\nPlease enter your second value:");
                    if (int.TryParse(Console.ReadLine(), out secondValue))
                    {
                        Console.WriteLine($"Your second value is: {secondValue}");
                        Console.ReadKey(); //keeping the terminal open + preventing constant looping for now
                    }// end if secondValue
                    else
                    {
                        Console.WriteLine("Please enter a valid integer value only.");
                    }// end else secondValue
                }// end if firstValue
                else
                {
                    Console.WriteLine("Please enter a valid integer value only.");
                }// end else firstValue
            }// end while loop

        } // end main method
    }// end class
}// end namespace
