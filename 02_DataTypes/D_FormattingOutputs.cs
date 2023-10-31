using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class demonstrates basic output formatting, will be using this to show formats of currencies etc.
*/

namespace _01b_DataTypes
{
    class D_FormattingOutputs
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Currency: {0:c}", 25.645); //formatting a currency value (this shows dollar symbol)
            Console.WriteLine("Pad w/ Zeros: {0:d4}", 28);
            Console.WriteLine("3 Decimals: {0:f3}", 23.12331);
            Console.WriteLine("Commas: {0:n4}", 2100);

        }//end main
    }//end class
}//end namespace
