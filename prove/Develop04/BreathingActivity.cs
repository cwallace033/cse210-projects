public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathting Activity", "This activity will help you relax by walking you through breathing in and out slowly")
        {

        }

        public void PerformActivity()
        {
            StartActivity();

            Console.WriteLine();
            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
            

            while (DateTime.Now < endTime)
            {
                if (DateTime.Now >= endTime) break;

                

                Console.Write ("Breath in...");
                Countdown(5);
                Console.WriteLine();
                Console.WriteLine();


                if (DateTime.Now >= endTime) break;

                Console.Write ("Breath out...");
                Countdown(5);
                Console.WriteLine();
                Console.WriteLine();

            }
            EndActivity();
        }


}