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
            //find the length of a string
            string randomString = "sophie is my friend";
            Console.WriteLine(randomString);
            Console.WriteLine(randomString.Length);

            //check if a string contains specific values
            Console.WriteLine("Does string contain 'sophie'? : {0}", randomString.Contains("sophie"));

            //find the index (where in the string) is the value 'sophie'
            Console.WriteLine("Index of the word 'sophie' : {0}", randomString.IndexOf("sophie"));

        }//end main
    }//end class
}//end namespace
