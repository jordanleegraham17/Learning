using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    /* In this class I will practice while loops - these have already been practiced in previous sections but for the sake of documenting and getting my hour
     * of code complete for today, we are going to create some basic programs with a while loop!
     */

    class A_WhileLoops
    {
        static void Main(string[] args)
        {
            //print a value X number of times based on another value
            int target = 10;
            int count = 0;

            while (count < target)
            {
                count++;
                Console.WriteLine($"{count}");
                //Console.ReadKey();
            }//end while loop
            Console.ReadKey(); //keeping the console open

        }//end main method
    }//end class
}//end namespace
