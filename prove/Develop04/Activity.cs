using System.Security.Cryptography;

public class Activity 
{
    protected int _duration = -1;
    private string _name = "";
    private string _description = "";

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to {_name}!");
        Console.WriteLine("How long would you like to spend in this activity? (answer in seconds)");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Thread.Sleep(250);
        Console.Write("Get ready...");
        Spinner();
        
    }

    public void EndActivity()
    {
        Console.WriteLine($"Thank you for taking part in {_name}. You have done a great job!");
        Console.WriteLine($"This activity took {_duration} seconds to complete");
        Spinner();
    }

    public void Spinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

     public void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

}