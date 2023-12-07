using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Address address = new Address("123 Main St", "Seattle", "WA", "USA");
        DateTime eventDate = new DateTime(2023, 12, 25);
        TimeSpan eventTime = new TimeSpan(10, 30, 0);
        Event eventInfo = new Event("Foundation3", "C# Programming", eventDate, eventTime, address, EventType.Normal);
        Console.WriteLine(eventInfo);
        Console.WriteLine(eventInfo.ShortDescription());
        Console.WriteLine("\n");

        Address lectureAddress = new Address("125 Main St", "Calif", "AZ", "USA");
        DateTime lectureDate = new DateTime(2023, 12, 24);
        TimeSpan lectureTime = new TimeSpan(12, 20, 0);
        Lecture lectureInfo = new Lecture("Foundation3", "Inheritance", lectureDate, lectureTime, lectureAddress, EventType.Lecture, "John Doe", "100");
        Console.WriteLine(lectureInfo);
        Console.WriteLine(lectureInfo.Details());
        Console.WriteLine(lectureInfo.ShortDescription());
        Console.WriteLine("\n");

        Address receptionAddress = new Address("500 Main St", "Alexan", "NY", "USA");
        DateTime receptionDate = new DateTime(2023, 12, 27);
        TimeSpan receptionTime = new TimeSpan(10, 39, 51);
        Reception receptionInfo = new Reception("Foundation3", "Poly Party", receptionDate, receptionTime, receptionAddress, EventType.Reception, "reception@gmail.com");
        Console.WriteLine(receptionInfo);
        Console.WriteLine(receptionInfo.Details());
        Console.WriteLine(receptionInfo.ShortDescription());
        Console.WriteLine("\n");

        Address outdoorAddress = new Address("100 Main St", "Seattle", "WA", "USA");
        DateTime outdoorDate = new DateTime(2023, 12, 26);
        TimeSpan outdoorTime = new TimeSpan(1, 30, 0);
        Outdoor outdoorInfo = new Outdoor("Foundation3", "C# Programming", outdoorDate, outdoorTime, outdoorAddress, EventType.Outdoor, "Sunny");
        Console.WriteLine(outdoorInfo);
        Console.WriteLine(outdoorInfo.Details());
        Console.WriteLine(outdoorInfo.ShortDescription());
        Console.WriteLine("\n");
          
    }
}