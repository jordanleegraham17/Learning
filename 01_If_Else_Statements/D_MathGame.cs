using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_If_Else_Statements
{

    /*
     *  the goal of this class will be to practice if else statements
     *  by creating a sample calculator which will add, multiply or subtract two values
     *  based on the user input of 'add' , 'multiply' and 'subtract'.
     *  
     *  *I am aware of and have implemented switch statements in the past however,
     *  I would like to get better at if else statments for the time being and focus on validating some inputs.
     */

    class D_MathGame
    {
        static void Main(String[] args)
        {
            Console.WriteLine("MathGame.cs is set as the startup class");

            // _______ code below here ____________
            int valueOne, valueTwo, result; // create variables for the two values and the result

            // take in the users first choice of value
            Console.WriteLine("Please enter your first value");
            valueOne = int.Parse(Console.ReadLine());

            // take in the users second choice of value
            Console.WriteLine($"Your first value is: {valueOne}, \nPlease enter your second value:");
            valueTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your second value is: {valueTwo}");
            
            // calculate and readback the result
            result = valueOne + valueTwo;
            Console.WriteLine($"{valueOne} + {valueTwo} = {result}");
            Console.ReadLine();
            
        } //end main method
    } //end class
} //end namespace
