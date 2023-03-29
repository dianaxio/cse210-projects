using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("3031 Mulberry Street", "Conroe", "Texas", "77302", "United States");
        addresses[1] = new Address("Rosario avenue, 3rd Street", "Santa Fe", "Santa Fe", "5115", "Argentina");
        addresses[2] = new Address("75 Battery Place", "New York City", "New York", "10280", "United States");
        Event[] events =  new Event[3];
        events[0] = new LectureEvent("C# Programming Speach","Get new programming knowledge with this new opening speech to C# programming language","05/10/2023","08:00pm",addresses[0],"Amelia","50 People");
        events[1] = new ReceptionEvent("Clara's Wedding","Come here to celebrate Clara's wedding","06/04/2023","03:30pm",addresses[1],"clara@gmail.com");
        events[2] = new OutdoorGatheringEvent("Sports Event","Come to the most exciting sporting event of all times","10/08/2023","10:00am",addresses[2],"Sunny");

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Event Number: {0}",i+1);
            Console.WriteLine("\nStandard Details Message:");
            Console.WriteLine(events[i].StandardMessage());
            Console.WriteLine("Full Details Message:");
            Console.WriteLine(events[i].FullDetailedMessage());
            Console.WriteLine("Short Description Message:");
            Console.WriteLine(events[i].ShortDescription());
        }

    }
}