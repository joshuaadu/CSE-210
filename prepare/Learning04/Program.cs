using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("John", "Learning04");
        MathAssignment mathAssignment = new MathAssignment("John", "Learning04", "1.1", "1-10");
        WritingAssignment writingAssignment = new WritingAssignment("John", "Learning04", "My First Writing Assignment");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}