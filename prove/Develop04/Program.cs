using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity= new BreathingActivity();
        ReflecttionActivity reflecttionActivity = new ReflecttionActivity();
        ListingActivity listingActivity = new ListingActivity();

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please choose one of the following options to help increase your mindfulness.");

        string userInput = "";
        int bactivity = 0;
        int ractivity = 0;
        int lactivity = 0;
        while(userInput != "4")
        {
            Console.Clear();
            Console.WriteLine($"You have performed the breathing activity {bactivity} times.");
            Console.WriteLine($"You have performed the reflection activity {ractivity} times.");
            Console.WriteLine($"You have performed the listing activity {lactivity} times.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.WriteLine("Please choose an activity by selecting its number: ");
            userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    breathingActivity.PerformActivity();
                    bactivity ++;
                    break;
                case "2":
                    reflecttionActivity.PerformActivity();
                    ractivity ++;
                    break;
                case "3":
                    listingActivity.PerformActivity();
                    lactivity ++;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid input. Please select 1-4.");
                    break;
            }
        }

    }
}