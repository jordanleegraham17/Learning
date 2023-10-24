using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ABOUT THIS CLASS;
 * the purpose of this little class is to enter all of the little operator functions such as
 * * for multiplication, + for addition, - for subtraction etc and modulus % for the remainders
 */

namespace _01b_DataTypes
{
    class B_Operators
    {
        static void Main(String[] args)
        {
            int firstValue = 5;
            int secondValue = 8;

            int additionResult = firstValue + secondValue;
            int subtractionResult = firstValue - secondValue;
            int multiplicationResult = firstValue * secondValue;
            int divisionResult = firstValue / secondValue;
            int modulusResult = firstValue % secondValue;

            Console.WriteLine(
                              $"Addition = {additionResult}\n" +
                              $"Subtraction = {subtractionResult}\n" +
                              $"Multiplication = {multiplicationResult}\n" +
                              $"Division = {divisionResult}\n" +
                              $"Modulus = {modulusResult}"
                             );


        }//end main
    }//end class
}//end namespace
