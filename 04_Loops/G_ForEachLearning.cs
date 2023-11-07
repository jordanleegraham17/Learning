using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* The purpose of this code is to practice a foreach loop.
 * I will practice a foreach, arrays and functions in this class for quick reference.
 */

namespace _04_Loops
{
    class G_ForEachLearning
    {
        static void Main(string[] args)
        {
            string greetingMessage = "Welcome, the program will now begin?..";
            Console.WriteLine(greetingMessage);

            int[] randomNumbers = { 10, 17, 2, 11, 8, 23, 25, 49, 32, 1 };

            PrintResult(randomNumbers); //calling the method to work on the above defined list of numbers

            Console.ReadKey();//keeping the command line alive
        }//end main

        // _____ OTHER METHODS _____

        //this method will sort the array and print "for each" before each item of the array
        static void PrintResult(int[] arrayResult)
        {
            Array.Sort(arrayResult);

            foreach (int i in arrayResult)
            {
                Console.WriteLine($"{i} ForEach");
            }
        }//end PrintResult method

    }//end class
}//end namespace
