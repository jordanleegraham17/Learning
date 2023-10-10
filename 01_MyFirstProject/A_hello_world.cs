using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _01_MyFirstProject
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // basic hello world type output to get things running
            Console.WriteLine("Welcome to my 50th C# project although this is the first on a new computer.");

            // calling the RequestUsername method
            RequestUsername();

        }

        // creating a method for requesting users name
        static void RequestUsername()
        {
            // adding a while loop to restart the program if the name is not correct
            while (true)
            {
                // taking in name and greeting the person by name
                Console.WriteLine("Please enter your name");
                String personsName = Console.ReadLine();

                // validating persons name
                if (personsName.Equals("Jordan", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Welcome {personsName}"); // reading the name back to the person using newer formatting
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect name, pls try again.");
                }
            }
        } 

    }
}
