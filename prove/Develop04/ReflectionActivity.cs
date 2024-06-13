public class ReflecttionActivity : Activity
{
    private Random _random;
    private List<string> _prompt;
    private List<string> _question;
    public ReflecttionActivity()
    : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") 
    {
        _question = new List<string> {"> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?"
        };

        _prompt = new List<string> {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};

        _random = new Random();

    }

    public void PerformActivity(){
        StartActivity();

        Console.WriteLine("Consider the following prompt:\n");

        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("Press enter when you have something in mind.\n");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        Countdown(5);
        Console.Clear();


        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write(GetRandomQuestion());
            Spinner();
            Spinner();
            Console.WriteLine();
            if (DateTime.Now >= endTime) break;
        }

        EndActivity();
    }

    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompt.Count);

        return _prompt[randomIndex];
    }

    public string GetRandomQuestion()
    {
        int randomIndex = _random.Next(_question.Count);
        return _question[randomIndex];
    }


}