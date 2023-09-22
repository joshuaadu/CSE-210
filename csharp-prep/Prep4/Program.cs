using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        bool loop = true;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (loop)
        {

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }

                Console.WriteLine($"The sum is {sum}.");
                float average = ((float)sum) / numbers.Count;
                Console.WriteLine($"The average is {average}");
                Console.WriteLine($"The largest number is {numbers.Max()}.");
                Console.WriteLine($"The smallest number is {numbers.FindAll(number => number > 0).Min()}.");
                Console.WriteLine($"The sorted list is: ");
                numbers.Sort();
                foreach (int num in numbers)
                {
                    Console.WriteLine($"{num} ");
                }
                loop = false;
            }

        }
    }
}