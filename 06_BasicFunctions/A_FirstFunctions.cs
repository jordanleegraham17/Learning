using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BasicFunctions
{
    class A_FirstFunctions
    {
        static void Main(string[] args)
        {
            // defining an integer array to pass to function
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8 };

            PrintArray(numbersArray, "ForEach");

            Console.ReadKey();
        }//end main

        // _____ FUNCTIONS _____

        static void PrintArray(int[] integerArray, string outputMessage)
        {
            foreach (int i in integerArray)
            {
                Console.WriteLine($"{outputMessage}, {i}");
            }//end foreach
        }//end printArray method

        // _____ END FUNCTIONS _____

    }//end class
}//end namespace
