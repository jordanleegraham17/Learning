using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BasicFunctions
{
    class D_PalindromeChecker
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Palindrome Checker\n");

            //prompt the user for input
            Console.WriteLine("Please enter a string value to check");
            String userWord = Console.ReadLine();

            //give the user back their word
            Console.WriteLine($"Your word is: {userWord}\n");

            //create an empty reverse of the user string
            String userWordReversed = "";


            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
