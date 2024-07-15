using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Smithfield", "UT", "USA");
        Address address2 = new Address("456 Elm St", "Brigham City", "UT", "USA");
        Address address3 = new Address("789 Oak St", "Ogden", "UT", "USA");

        Lecture lecture = new Lecture("Tech Talk", "A talk about tech. Super fun stuff", "2024-07-10", "10:00 AM", address1, "Dr. Jane Doe", 100);
        Reception reception = new Reception("Company Party", "Annual company party. wild stuff", "2024-07-11", "06:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "Join us for a fun day!!", "2024-07-12", "12:00 PM", address3, "Sunny with a chance of showers");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (Event ev in events)
        {
            if (ev is Lecture lec)
            {
                Console.WriteLine(lec.GetStandardDets());
                Console.WriteLine(lec.GetFullDets());
                Console.WriteLine(lec.GetShortDets("Lecture"));
            }
            else if (ev is Reception rec)
            {
                Console.WriteLine(rec.GetStandardDets());
                Console.WriteLine(rec.GetFullDets());
                Console.WriteLine(rec.GetShortDets("Reception"));
            }
            else if (ev is OutdoorGathering outGathering)
            {
                Console.WriteLine(outGathering.GetStandardDets());
                Console.WriteLine(outGathering.GetFullDets());
                Console.WriteLine(outGathering.GetShortDets("Outdoor Gathering"));
            }
            Console.WriteLine();
        }
    }
}
