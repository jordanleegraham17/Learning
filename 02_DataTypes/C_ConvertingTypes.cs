using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* About this class:
 * Using this class to demonstrate quick conversions of data types.
 * These conversions always come in handy and it is useful to have,
 * a demonstrable class with some of the conversions saved to reference back to.
 */

namespace _01b_DataTypes
{
    class C_ConvertingTypes
    {
        static void Main(String[] args)
        {
            // EXAMPLE CONVERSION FROM STRING TO VALUE
            //________________________________________

            // converting a string into a boolean value - must make logical sense to work
            bool boolFromString = bool.Parse("true");
            Console.WriteLine(boolFromString);
            Console.WriteLine($"boolFromString type = {boolFromString.GetType()}\n");

            // converting a string into an integer
            int integerFromString = int.Parse("2023");
            Console.WriteLine(integerFromString);
            Console.WriteLine($"integerFromString type = {integerFromString.GetType()}\n");

            // converting a double from a string value (can be done w/ most value types)
            double doubleFromString = double.Parse("2.517");
            Console.WriteLine(doubleFromString);
            Console.WriteLine($"doubleFromString type = {doubleFromString.GetType()}\n");

            // EXAMPLE CONVERSION FROM VALUE TO STRING
            //_________________________________________

            // converting earliers int value back into a string!
            string stringFromInteger = integerFromString.ToString();
            Console.WriteLine(stringFromInteger);
            Console.WriteLine($"stringFromInteger type = {stringFromInteger.GetType()}\n");

            /* example of 'explicit' conversion 
             * - when we convert a double into an integer we lose the decimal values stores in the double
             * whenever we lost some data through the conversion it is considered 'explicit'.
            */
            double doubleValue = 2.023;
            Console.WriteLine($"integer converted from double value = {(int)doubleValue}\n"); // can do this conversion inside the brackets

        }//end main
    }//end class
}//end namespace
