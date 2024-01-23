using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ABOUT
 * FizzBuzz is a numerical game
 * The game works by counting as normal
 * The rules are:
 * Whenever your number is divisible by 3 you instead say FIZZ! instead of your number.
 * Whenever your number is divisible by 5 you instead say BUZZ! instead of your number.
 * If your number is divisible by both 3 AND 5, you say FIZZBUZZ!! instead of your number.
 * If your number doesn't meet any of the rules above, you simply say the number :).
 */

namespace _06_BasicFunctions
{
    class C_FizzBuzz
    {

        public static void Main(String[] args)
        {

            // define a number to start with
            int startingValue = 0;

            // begin counting from that number upwards
            while (startingValue >= 0 & startingValue < 50)
            {
                startingValue++;
                if (startingValue % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(startingValue);
                }
            }//end while loop

            Console.ReadKey(); //keeping terminal alive for now

        }//end main
    }//end class
}//end namespace
