using System;

class Program
{
    static void Main(string[] args)
    {
        //uncomment to test end verse
        // Reference reference = new Reference("John", 3, 16, 18);
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture (reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while(true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsErased())
            {
                break;
            }

            Console.WriteLine("Press enter to hide more words or type quit to stop.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else
            {
                scripture.EraseWords();
            }
        }
    }
}