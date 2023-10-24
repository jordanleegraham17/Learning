using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* The goal of this class is to show all of the even numbers between 2-20
 * I might also make this user defined to practice validating integers entered by users
 * and handling them with the code as it is a fairly new concept
 */

namespace _04_Loops
{
    class C_EvenNumbers
    {
        static void Main(String[] args)
        {
            bool programClosed = false; //using this to open and close the loop - essentially opening and closing the prompts

            while (!programClosed)
            {
                // ask user for value to enter and read the input
                Console.WriteLine("Welcome, please enter a max value you would like to see the even numbers of: ");
                string userInput = Console.ReadLine();
                int currentValue = 0;

                //if statement to validate user input is an integer
                if (int.TryParse(userInput, out int userValue))
                {
                    Console.WriteLine($"\nNow printing all EVEN values up until {userValue}...");
                    while (currentValue < userValue)
                    {
                        // just printing all numbers up until the user defined value for now to have the program going..
                        currentValue++;
                        if (currentValue/currentValue == 2)
                        {
                            Console.WriteLine(currentValue);
                        }
                        else
                        {
                            currentValue++;
                        }
                    }//end while loop
            
                }//end if for int validation
                else
                {
                    Console.WriteLine("Please enter an integer value only.");
                }//end else
                Console.ReadKey();
            }//end while loop
 
        }//end main
    }//end class
}//end namespace
