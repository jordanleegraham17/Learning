using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MyFirstProject
{
    /*
     * The purpose of this class is to have a reference class for various data types such as int, bool, string, float etc.
     */
    class A_DifferentTypes
    {
        static void Main(String[] args)
        {
            byte byteValue = 255; // 0 to 255
            sbyte sbyteValue = -128; // -128 to 127
            short shortValue = 32767; // -32,768 to 32,768
            ushort ushortValue = 0; // 0 to 65,535
            int intValue = -2147483648; // -2,147,483,648 to 2,147,483,647
            uint uintValue = 4294967295; // 0 to 4,294,967,295
            long longValue = 9223372036854775807; //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong ulongValue = 18446744073709551615; // 0 to 18,446,744,073,709,551,615
            float floatValue = 3.402823e38f; //-3.402823e38 to 3.402823e38 (add 'f' for float literal)
            decimal decimalValue = 1.8m; // Add 'm' for decimal literal
            char charValue = '\x0058'; // Assign a single character
            bool boolValue = false;
            string stringValue = "String";
            DateTime dateTimeValue = DateTime.MinValue;

            Console.WriteLine(byteValue);
            Console.WriteLine(sbyteValue);
            Console.WriteLine(shortValue);
            Console.WriteLine(ushortValue);
            Console.WriteLine(intValue);
            Console.WriteLine(uintValue);
            Console.WriteLine(longValue);
            Console.WriteLine(ulongValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(decimalValue);
            Console.WriteLine(charValue);
            Console.WriteLine(boolValue);
            Console.WriteLine(stringValue);
            Console.WriteLine(dateTimeValue);

        }//end main
    }//end class
}//end namespace
