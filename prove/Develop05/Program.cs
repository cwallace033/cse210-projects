using System;
using System.Runtime.InteropServices;



class Program
{
    static void Main(string[] args)
    {
        int points = 0;

        Console.WriteLine("Welcome to the Goals Game!");
        Console.WriteLine("Please choose one of the following options to set or record a goal.");

        string userInput = "";
        
        while(userInput != "6")
        {
            Console.Clear();
            Console.WriteLine($"You have {points}.");
            
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");

            Console.WriteLine("Please choose an activity by selecting its number: ");
            userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("    1. Simple Goal");
                    Console.WriteLine("    2. Eternal Goal");
                    Console.WriteLine("    3. Checklist Goal");
                    Console.WriteLine("Which Goal would you like to create?");
                    userInput = Console.ReadLine();

                    switch(userInput)
                    {
                        case "1":
                            // simple goal
                            break;
                        case "2":
                            // Eternal goal
                            break;
                        case "3":
                            // Checklist goal
                            break;
                        default:
                            Console.WriteLine("Please enter a number 1-3");
                            break;
                    }
                    break;
                case "2":
                    // List Goals
                    break;
                case "3":
                    // Save Goals
                    break;
                case "4":
                    // Load Goals
                    break;
                case "5":
                    // Record Event
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Invalid input. Please select 1-6.");
                    break;
            }
        }
    }
}