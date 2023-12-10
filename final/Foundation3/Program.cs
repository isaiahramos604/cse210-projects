using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Cityville", "CityState", "12345");
        Address receptionAddress = new Address("456 Elm St", "Townsville", "TownState", "67890");
        Address outdoorGatheringAddress = new Address("789 Oak St", "Villagetown", "VillageState", "13579");

        Lecture lectureEvent = new Lecture("C# Basics", "Introduction to C# programming", DateTime.Now.Date, new TimeSpan(14, 0, 0), lectureAddress, "Johny Dhon", 50);
        Reception receptionEvent = new Reception("Networking Mixer", "Networking event for professionals", DateTime.Now.Date.AddDays(7), new TimeSpan(18, 30, 0), receptionAddress, "info@example.com");
        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Picnic in the Park", "Community gathering for a picnic", DateTime.Now.Date.AddDays(14), new TimeSpan(12, 0, 0), outdoorGatheringAddress, "Sunny skies");

        DisplayEventDetails(lectureEvent);
        DisplayEventDetails(receptionEvent);
        DisplayEventDetails(outdoorGatheringEvent);
    }

    static void DisplayEventDetails(Event eventObj)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(eventObj.GetStandardDetails());
        Console.WriteLine();
        Console.ReadLine();
        

        Console.WriteLine("Full Details:");
        Console.WriteLine(eventObj.GetFullDetails());
        Console.WriteLine();
        Console.ReadLine();
        

        Console.WriteLine("Short Description:");
        Console.WriteLine(eventObj.GetShortDescription());
        Console.WriteLine();
        Console.ReadLine();
        
    }
    
}