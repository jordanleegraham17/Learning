using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01b_DataTypes
{
    class E_StringFunctions
    {
        static void Main(String[] args)
        {
            //declaring a string to start off with - will perform the operations on this string
            string randomString = "sophie is my friend";
            Console.WriteLine($"This is my starting string : {randomString}");

            //find the length of a string
            Console.WriteLine("Length of the string : {0}",randomString.Length);

            //check if a string contains specific values
            Console.WriteLine("Does string contain 'sophie'? : {0}", randomString.Contains("sophie"));

            //find the index (where in the string) is the value 'sophie'
            Console.WriteLine("Index of the word 'sophie' : {0}", randomString.IndexOf("sophie"));

            //remove the string after a specific index
            Console.WriteLine("Remove part of the string between set index : {0}", randomString.Remove(8,6));

            //insert into the string after a specific index
            Console.WriteLine("Insert into the string : {0}", randomString.Insert(6, " Bell "));

            //replace a string with another
            Console.WriteLine("Replacing string : {0}", randomString.Replace("is my friend", "is my bestest friend"));

        }//end main
    }//end class
}//end namespace
