public class ListingActivity : Activity{
    private List<string> _prompts;

    private Random _random;

    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string> 
        {"Who are people that you appreciate?",
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};

        _random = new Random();
    }

    public void PerformActivity()
    {
        StartActivity();

        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();

        
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        int items = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            items ++;
        }

        Console.WriteLine($"You have listed {items} items!");

        EndActivity();
    }



    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }
}