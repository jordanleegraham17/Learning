using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_If_Else_Statements
{

    /* ABOUT: this is a second mini project for practicing IF ELSE statements.
     * the goal for this class is to create a very basic version of a login system.
     */
    internal class _02_LoginIfElse //learning about internal keyword for encapsulation - different to Java
    {
        static void main()
        {
            String userName = "Jordan";
            String passWord = "123456";

            // objective 1: Greet the user
            String welcomeMessage = "Welcome to the login system.";
            Console.WriteLine($"{welcomeMessage}");

            // objective 2: Prmpt the user for their userName

            // objective 3: Accept user input and verify if it is the correct userName

            // objective 4: If Else statement, if the userName is correct prompt the user for their passWord; else ask again

            // objective 5: verify the user passWord, if correct welcome display "Logged In"

        }// end main
    }// end class
}// end namespace
