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
    class LoginSystem //learning about internal keyword for encapsulation - different to Java
    {
        public static void Main(String[] args)
        {
            String userName = "Jordan";
            String passWord = "123456";

            // objective 1: Greet the user
            String welcomeMessage = "Welcome to the login system.";
            Console.WriteLine($"{welcomeMessage}");

            // objective 2: Prmpt the user for their userName
            Console.WriteLine("Please enter your assigned Username:");
            String userNameAttempt = Console.ReadLine();

            // objective 3: Accept user input and verify if it is the correct userName
            if (userNameAttempt != null)
            {
                // objective 4: If Else statement, if the userName is correct prompt the user for their passWord; else ask again
                if (userNameAttempt == userName)
                {
                    Console.Write($"Welcome {userName}, please enter your password:");
                    String passWordAttempt = Console.ReadLine();
                    
                    if(passWordAttempt != null)
                    {
                        // objective 5: verify the user passWord, if correct welcome display "Logged In"
                        if (passWordAttempt == passWord)
                        {
                            Console.WriteLine("LOGGED IN WOO");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Password");
                        }
                    }// end if password = null
                } // end if username = username
                else
                {
                    Console.WriteLine("Incorrect username, please try again");
                }
            }// end if username = null
            else 
            {
                Console.WriteLine("Please enter a username.");
            }

        }// end main
    }// end class
}// end namespace
