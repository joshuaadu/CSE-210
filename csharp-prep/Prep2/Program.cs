using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        string gradeSign = "";

        if (grade >= 60 && grade <= 96)
        {

            if (grade % 10 >= 7)
            {
                gradeSign = "+";
            }
            else if (grade % 10 <= 3)
            {
                gradeSign = "-";
            }

        }
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}{gradeSign}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}