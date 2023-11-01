using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class D_ForLoops_Intro
    {
        static void Main(String[] args)
        {
            //declaring an array (of type string)
            string[] airlinesArray = { "Aer Lingus", "Ryanair", "Whizz Air" };

            // practicing for loops
            for (int i = 0; i < airlinesArray.Length; i++)
            {
                Console.WriteLine(airlinesArray[i]); // should print out each item of the for loop
            }

            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
