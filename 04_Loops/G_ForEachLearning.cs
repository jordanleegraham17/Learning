﻿using System;
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
            //variables
            string greetingMessage = "Welcome, the program will now begin?..";

            //program begins
            Console.WriteLine(greetingMessage);

            int[] randomNumbers = { 10, 17, 2, 11, 8, 23, 25, 49, 32, 1 };

            PrintResult(randomNumbers); //calling the method to work on the above defined list of numbers

            Console.ReadKey();//keeping the command line alive
        }//end main

        // _____ OTHER METHODS _____

        //this method will sort the array and print "for each" before each item of the array
        static void PrintResult(int[] arrayResult)
        {
            string unevenMessage = "This value is uneven!";
            string evenMessage = "This value IS EVEN!";

            Console.WriteLine($"Your array sorted : {arrayResult}");

            foreach (int i in arrayResult)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} : {evenMessage}");
                }
                else
                {
                    Console.WriteLine($"{i} : {unevenMessage}");
                }
            }//end foreach
        }//end PrintResult method

    }//end class
}//end namespace
