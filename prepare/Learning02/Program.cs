using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2017;
        // Console.WriteLine(job1._company);
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Sofware Developer";
        job2._company = "Apple";
        job2._startYear = 2015;
        job2._endYear = 2017;
        // Console.WriteLine(job2._company);
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.display();
    }
}