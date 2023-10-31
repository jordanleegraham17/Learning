using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _01b_DataTypes
{
    class F_Arrays
    {
        static void Main(String[] args)
        {
            //declaring an array (of type int)
            int[] favouriteNumbers = new int[3];

            //adding a value to the array
            favouriteNumbers[0] = 2;
            favouriteNumbers[1] = 17;
            favouriteNumbers[2] = 23;

            //showing a value from the array
            Console.WriteLine("The first value in the array is : {0}",favouriteNumbers[0]);
            Console.WriteLine("The second value in the array is : {0}", favouriteNumbers[1]);
            Console.WriteLine("The third value in the array is : {0}", favouriteNumbers[2]);

            //declaring an array (of type string)
            string[] airlines = {"Aer Lingus","Ryanair","Whiz Air"};

            //showing a value from a string array
            Console.WriteLine(airlines[0]);
            Console.WriteLine(airlines[1]);
            Console.WriteLine(airlines[2]);

            //declaring an array of different data types
            object[] randomArray = {"Swizz Air", 320, 2.51};

            //find the data type of an array item
            Console.WriteLine("Data Type of item 3 (index of 2) : {0}",randomArray[2].GetType());

            //identify the size of an array (its the same as string)
            Console.WriteLine("Size of array = {0}",randomArray.Length);


        }//end main
    }//end class
}//end namespace
