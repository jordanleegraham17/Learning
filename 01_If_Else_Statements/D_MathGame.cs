using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
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
            int valueOne, valueTwo; // create variables for the two values and the result
            bool isValidInput = false; //using this to validate user input
            bool isValidOperation = false; // using this to validate user operation choice (for this practice have purposely avoided the switch statement)

            // while loop to continue asking user for an input
            while (!isValidInput)
            {
                Console.WriteLine("Please enter your first value");

                // taking in and validating the user input for valueOne is an integer
                if (int.TryParse(Console.ReadLine(), out valueOne))
                {
                    isValidInput = true; // the user did enter an integer value
                    // take in the users second choice of value
                    Console.WriteLine($"Your first value is: {valueOne}, \nPlease enter your second value:");
                    
                    // while loop to continue asking user for second value
                    while (isValidInput == true)
                    {
                        // take in and validate user input for valueTwo
                        if (int.TryParse(Console.ReadLine(), out valueTwo))
                        {
                            Console.WriteLine($"Your second value is: {valueTwo} ");

                            //prompt user for a choice of operation
                            while (!isValidOperation)
                            {
                                //prompt user for a choice of operation (add, subtract, divide, multiply)
                                Console.WriteLine("Please enter the operation you would like to apply;");
                                Console.WriteLine("Addition, Subtraction, Division, Multiplication:");
                                // read the operation choice to decide on next action
                                string operationChoice = Console.ReadLine();

                                if (operationChoice.Equals("Addition", StringComparison.OrdinalIgnoreCase))
                                {
                                    AddValues(valueOne,valueTwo);
                                }
                                else if (operationChoice.Equals("Subtraction", StringComparison.OrdinalIgnoreCase))
                                {
                                    SubtractValues(valueOne,valueTwo);
                                }
                                else if (operationChoice.Equals("Division", StringComparison.OrdinalIgnoreCase))
                                {
                                    DivideValues(valueOne, valueTwo);
                                }
                                else if (operationChoice.Equals("Multiplication", StringComparison.OrdinalIgnoreCase))
                                {
                                    MultiplyValues(valueOne, valueTwo);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid operation name.");
                                }
                            }//end while !validOperation
                        } //end if
                        else
                        {
                            Console.WriteLine("Incorrect input, please enter a valid integer");
                        } //end else
                    }// end while loop
                }// end if
                else
                {
                    Console.WriteLine("Incorrect input, please enter a valid integer"); // warning msg to user
                }// end else
            }// end while          
        } //end main method

        // addition method for adding both values together
        static void AddValues(int valueOne, int ValueTwo)
        {
            int additionResult = valueOne + ValueTwo;
            Console.WriteLine($"{valueOne} + {ValueTwo} = {additionResult}");
            Console.ReadKey();
        }

        // subtraction method for subtracting values from one another
        static void SubtractValues(int valueOne, int ValueTwo)
        {
            int subtractResult = valueOne - ValueTwo;
            Console.WriteLine($"{valueOne} - {ValueTwo} = {subtractResult}");
            Console.ReadKey();
        }

        // division method for dividing the values by one another, only the first input divided by second input
        static void DivideValues(int valueOne, int valueTwo)
        {
            int divisionResult = valueOne / valueTwo;
            Console.WriteLine($"{valueOne}/{valueTwo} = {divisionResult}");
        }

        // multiplication method for multiplying the two values entered by the user
        static void MultiplyValues(int valueOne, int valueTwo)
        {
            int multiplicationResult = valueOne * valueTwo;
            Console.WriteLine($"{valueOne} * {valueTwo} = {multiplicationResult}");
            Console.ReadKey();
        }

    } //end class
} //end namespace
