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

            //check can we loop through each letter of the string
            for (int i = userWord.Length - 1; i >= 0; i--)
            {
                userWordReversed += userWord[i]; //adding each letter backwards to the empty reversed string
            }

            //check if the above successfully reversed the string
            Console.WriteLine($"The reversed string is: {userWordReversed}");

            //check if the word was a palindrome
            if (userWordReversed == userWord)
            {
                Console.WriteLine("\nPALINDROME ALERT!");
            }
            else
            {
                Console.WriteLine("\nNot a Palindrome, try again!");
            }

            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
