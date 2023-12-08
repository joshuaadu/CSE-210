using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        var activities = new Activity[]
        {
            new Running(new DateTime(2020, 1, 1), 30, 3.5, ActivityType.Running),
            new Cycling(new DateTime(2020, 1, 2), 45, 15, ActivityType.Cycling),
            new Swimming(new DateTime(2020, 1, 3), 45, 20, ActivityType.Swimming)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());

        }

    }
}