using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ABOUT
 * The purpose of this class is to do an age voting checker.
 * A user will enter their age and the program will let them know if they can or cannot vote.
 * A main goal for this class is to also incorporate user input validation, ensuring the user enters a valid integer
*/

namespace _01_If_Else_Statements
{
    class E_VoteChecker
    {
        static void Main(String[] args)
        {
            string programDescription = "The purpose of this class is to do an age voting checker.\n" +
                "A user will enter their age and the program will let them know if they can or cannot vote.\n" +
                "A main goal for this class is to also incorporate user input validation, ensuring the user enters a valid integer\n\n";

            Console.WriteLine(programDescription);


            Console.ReadKey();//keeping the console alive

        }//end main
    }//end class
}//end namespace
