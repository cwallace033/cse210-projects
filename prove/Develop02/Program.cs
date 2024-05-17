using System;
using System.Collections.Generic;
using System.IO;

public class Entry{
    public string _prompt = "";

    public string _response = ""; 

    public string _date = "";

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }
    //function to make the format all pretty
    public string FormattedEntry
    {
        get
        {
            return $"Date: {_date}\nPrompt:{_prompt}\nResponse: {_response}";

        }
    }

    public string SavingEntry
    {
        get
        {
            return $"Date: {_date}~~Prompt: {_prompt}~~Response: {_response}";
        }
    }
}

public class Journal{
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something that made you laugh today?",
        "What was a trial you overcame today?"
    };

    //fucntion for writing 
    public void WriteEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Your Prompt is {prompt}");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("dd-MM-yyyy");

        Entry entry = new Entry(prompt, response, date);
        _entries.Add(entry);

    }
    //function to display
    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.FormattedEntry);
        }
    }


    //function for saving
    public static void SaveToFile(List<Entry> entries)
    {
        Console.WriteLine("What would you like to name the file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.SavingEntry);
            }
        }
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    //function for loading
    public static void ReadFromFile(string file)
    {
        Console.WriteLine("Reading list from file.");
        List<Entry> entries = new List<Entry>();
        string filename = file;

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string [] parts = line.Split("~~");

            Entry newEntry = new Entry(parts[1], parts[2], parts[0]);
            entries.Add(newEntry);
        }
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.FormattedEntry);
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }


}

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the journal program!");

        bool exit = false;

        while (!exit){
            Console.WriteLine("Please select one of the following choices: ");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.WriteLine("\nWrite a new entry");
                    journal.WriteEntry();
                    break;

                case "2":
                    Console.WriteLine("\nDisplay the journal");
                    journal.DisplayEntry();
                    break;

                case "3":
                    Console.WriteLine("Load the journal");
                    Console.WriteLine("What is the file name?");
                    string filename = Console.ReadLine();
                    Journal.ReadFromFile(filename);
                    break;

                case "4":
                    Console.WriteLine("Save the journal");
                    Journal.SaveToFile(journal.GetEntries());
                    break;
                
                case "5":
                    Console.WriteLine("Quitting journal");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("That is not an option");
                    break;
            }
        }
        
    }
}