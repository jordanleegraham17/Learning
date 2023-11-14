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
        //global variables
        bool validInput = true;
        string aircraftType;

        static void Main(String[] args)
        {
            //variables
            string welcomeMessage = "Welcome, please follow the prompts to enter your flight data.";
            
            //program begins
            Console.WriteLine(welcomeMessage);

            //prompt user for their aircraft type
            AircraftSelection();

        }//end main

        //_____ OTHER METHODS ______
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
                    switch (userAircraftSelection)
                    {
                        case 1:
                            string aircraftType = "Cessna 152";
                            Console.WriteLine($"You have selected : {aircraftType}");
                            WeightCalculation(aircraftType);
                            break;
                        case 2:
                            aircraftType = "Cessna 172";
                            Console.WriteLine($"You have selected : {aircraftType}");
                            WeightCalculation(aircraftType);
                            break;
                        default:
                            Console.WriteLine("You did not choose a valid aircraft type, please try again.");
                            AircraftSelection();
                            break;
                    }//end switch statement
                }//end if validate user selection
                else
                {
                    Console.WriteLine("Please enter a valid integer to a corresponding aircraft in the list.");
                }//end else
            }//end while loop
        }//end AircraftSelection() method

        static void WeightCalculation(string aircraftType)
        {
            //variables
            bool validInput = true;
            string fuelWeight;
            int passengerWeight;
            string luggageWeight;
            int numberOfPassengers;
            int coPilotOnboardSelection;

            //console output so we know this method has been reached - will remove after testing
            Console.WriteLine($"\nBeginning Weight Calculations for type {aircraftType}...");

            //calculating passenger weight
            if (aircraftType == "Cessna 172")
            {
                while (validInput)
                {
                    Console.WriteLine("Please enter the number of passengers on board: ");
                    if (int.TryParse(Console.ReadLine(), out numberOfPassengers))
                    {
                        for (int i = 1; i <= numberOfPassengers; i++)
                        {
                            Console.WriteLine($"\nPlease enter the weight of passenger {i} in Kilograms (KG)");
                            passengerWeight = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Passenger {i} weight: {passengerWeight}KG");

                        }//end for loop
                    }//end if
                    else
                    {
                        Console.WriteLine("Please use a numerical value to indicate the number of passengers, eg: 3");
                    }//end else
                }//end while
            }//end if
            else
            {
                //handle when the aircraft selection is for a cessna 152 (cannot hold passengers)
                while(validInput)
                {
                    Console.WriteLine("\nDo you have a co-pilot on board?");
                    Console.WriteLine("1. Yes\t2.No");
                    if (int.TryParse(Console.ReadLine(), out coPilotOnboardSelection))
                    {
                        bool coPilotOnboard = coPilotOnboardSelection == 1 ? true : false;
                        Console.WriteLine($"Co-Pilot onboard: {coPilotOnboard}");
                        if (coPilotOnboard == true)
                        {
                            Console.WriteLine("Please enter the co-pilots weight in Kilograms (KG): ");
                            int coPilotWeight = Console.Read();
                            Console.WriteLine($"Co-Pilot Weight = {coPilotWeight}KG");
                        }//end if
                        else
                        {
                            Console.WriteLine("Please enter the pilot weight only : ");
                            int pilotWeight = Console.Read();
                            Console.WriteLine($"Pilot Weight = {pilotWeight}KG");
                        }//end else
                    }//end if
                    else
                    {
                        Console.WriteLine("Please enter a valid integer to the corresponding selection in the list.");
                    }//end else
                }//end while
            }//end else

            Console.ReadKey();//keeping the command line alive
        }//end WeightCalculation method


    }//end class
}//end namespace