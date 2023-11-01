using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Using this class to practice the coding challenge 'sum of integers'. 
 * The goal of this program will be to use a for loop or for each loop to calculate the sum of all integers
 * from  1 - N , with N being a user defined value.
 */

namespace _04_Loops
{
    class D_SumOfIntegers
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter a value you would like to stop calculating at: ");
            
            // retrieving the user defined value
            int userValueN = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nYou have entered: {userValueN}, which is of type: {userValueN.GetType()}");

            // defining a sum value
            int sum = 0;

            // for loop to print each value from 1-N
            for (int i = 1; i <= userValueN; i++)
            {
                // printing out each value between 1-N 
                Console.WriteLine(i);

                sum += i;
            }//end for loop

            Console.WriteLine($"\nThe sum of integers between 1-{userValueN} is: {sum}");

            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
