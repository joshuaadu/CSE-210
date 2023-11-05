using System;
using System.Collections.Generic;
using System.Threading;

/*
Keeping a log of how many times activities were performed.
Make sure no random prompts/questions are selected until they have all been used at least once in that session.
*/
class Program
{
    static void Main(string[] args)
    {
        int activityChoice = 0;
        bool endActivity = false;
        int numberOfActivities = 0;


        while (!endActivity)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activity Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity (1-4): ");
            while (!int.TryParse(Console.ReadLine(), out activityChoice) && !(activityChoice >= 1 && activityChoice <= 4))
            {
                Console.WriteLine("Invalid menu choice.");
                Console.Write("Choose an activity (1-4): ");
            }

            switch (activityChoice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                    breathingActivity.Initialize();
                    breathingActivity.Run();
                    breathingActivity.Done();
                    ++numberOfActivities;
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectionActivity.Initialize();
                    reflectionActivity.Run();
                    reflectionActivity.Done();
                    ++numberOfActivities;

                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Initialize();
                    listingActivity.Run();
                    listingActivity.Done();
                    ++numberOfActivities;
                    break;
                case 4:
                    endActivity = true;
                    break;
                default:
                    Console.WriteLine("Invalid menu choice.");
                    break;
            }

        }
        Console.WriteLine($"You have completed {numberOfActivities} activities today.");

    }
}