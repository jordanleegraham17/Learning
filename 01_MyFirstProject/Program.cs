using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic hello world type output to get things running
            Console.WriteLine("Welcome to my 50th C# project although this is the first on a new computer.");

            // taking in name and greeting the person by name
            Console.WriteLine("Please enter your name");
            String personsName = Console.ReadLine();

            // validating persons name
            if (personsName.Equals("Jordan", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Welcome {personsName}"); // reading the name back to the person using newer formatting
                Console.ReadLine(); // using this line to keep the cmd prmpt open
            }
            else
            {
                Console.WriteLine("Incorrect name, pls try again.");
                Console.ReadLine();
            }

        }
    }
}
