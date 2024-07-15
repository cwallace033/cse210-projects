using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running( "07/15/2024", 45, 3.0),
            new Cycling("07/16/2024", 10, 15.0),
            new Swimming("07/17/2024", 60, 35)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}