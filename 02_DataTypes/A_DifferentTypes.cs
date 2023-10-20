using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02_DataTypes
{
    class A_DifferentTypes
    {

        static void Main(string[] args)
        {
            byte byteValue = 255; // 0 to 255
            sbyte sbyteValue = -128; // -128 to 127
            short shortValue = 32767; // -32,768 to 32,767
            ushort ushortValue = 0; // 0 to 65,535
            int intValue = -2147483648; // -2,147,483,648 to 2,147,483,647
            uint uintValue = 4294967295; // 0 to 4,294,967,295
            long longValue = 9223372036854775807; //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong ulongValue = 18446744073709551615; // 0 to 18,446,744,073,709,551,615
            float floatValue = 3.402823e38f; //-3.402823e38 to 3.402823e38 (add 'f' for float literal)
            decimal decimalValue = 1.8m; // Add 'm' for decimal literal
            char charValue = 'X'; // Assign a single character
            bool boolValue = false; // Represents a Boolean value, true or false
            string stringValue = "String"; // Represents a sequence of characters
            DateTime dateTimeValue = DateTime.MinValue; // Represents the minimum value for DateTime

            Console.WriteLine("byteValue: " + byteValue); // 0 to 255
            Console.WriteLine("sbyteValue: " + sbyteValue); // -128 to 127
            Console.WriteLine("shortValue: " + shortValue); // -32,768 to 32,767
            Console.WriteLine("ushortValue: " + ushortValue); // 0 to 65,535
            Console.WriteLine("intValue: " + intValue); // -2,147,483,648 to 2,147,483,647
            Console.WriteLine("uintValue: " + uintValue); // 0 to 4,294,967,295
            Console.WriteLine("longValue: " + longValue); //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Console.WriteLine("ulongValue: " + ulongValue); // 0 to 18,446,744,073,709,551,615
            Console.WriteLine("floatValue: " + floatValue); //-3.402823e38 to 3.402823e38
            Console.WriteLine("decimalValue: " + decimalValue); // 1.8
            Console.WriteLine("charValue: " + charValue); // Assign a single character
            Console.WriteLine("boolValue: " + boolValue); // false
            Console.WriteLine("stringValue: " + stringValue); // String
            Console.WriteLine("dateTimeValue: " + dateTimeValue); // DateTime.MinValue
        }//end main
    }//end class
}//end namespace