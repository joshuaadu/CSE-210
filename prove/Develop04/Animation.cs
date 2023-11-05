using System;

class Animation
{

    static public void Wait(int seconds)
    {
        Thread.Sleep(seconds);
    }

    static public void Countdown(int count)
    {
        for (int i = count; i > 0; i--)
        {
            Console.Write(i);
            Wait(1000);
            Console.Write("\b \b");
        }
    }

    static public void Spinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        int index = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinner[index++ % spinner.Length]}");

            Wait(1000);
        }
        Console.Write("\b \b");
    }

    static public void DottedSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Wait(1000);
        }
    }
}