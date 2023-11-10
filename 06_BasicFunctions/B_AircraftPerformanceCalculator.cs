﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* About this project:
 * This is a mini project to replicate a simple aircraft performance calculator.
 * The goal of this mini project is to make use of different conditional statements and data types I have learned so far.
 * Implementing these different tools as much as possible through different logical functions to complete the task.
 * Plan:
 * The plan for this project is to initially take in various inputs from the user and read the information back,
 * such as a selection of aircraft type, weight (passengers + baggage + fuel), fuel on board etc.
*/

namespace _06_BasicFunctions
{
    class B_AircraftPerformanceCalculator
    {
        static void Main(String[] args)
        {
            //variables
            string welcomeMessage = "Welcome, please follow the prompts to enter your flight data.";
            
            //program begins
            Console.WriteLine(welcomeMessage);

            //prompt user for their aircraft type
            AircraftSelection();

        }//end main

        static void AircraftSelection()
        {
            //variables
            int userAircraftSelection;
            bool validInput = true;

            //set the users choice of aircraft based on input
            while (validInput)
            {
                //prompt user for their selection
                Console.WriteLine("\nPlease select an aircraft type from the following list");
                Console.WriteLine("1. Cessna 152\t2. Cessna 172");

                //validate the users input choice as an integer value and not different characters
                if (int.TryParse(Console.ReadLine(), out userAircraftSelection))
                {
                    Console.WriteLine($"You have selected : {userAircraftSelection}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer to the corresponding aircraft in the list");
                }
            }
        }//end AircraftSelection() method 


    }//end class
}//end namespace
