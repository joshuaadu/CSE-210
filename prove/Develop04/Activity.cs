class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    protected DateTime _startTime;
    // private int _numberOfActivities = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        // ++_numberOfActivities;
    }

    public void Initialize()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        int duration = 0;
        Console.Write("How long in seconds, would you like to do this session? ");

        while (!int.TryParse(Console.ReadLine(), out duration))
        {
            Console.Write("Invalid input. Please enter a number for seconds: ");
        }

        _duration = duration;
    }

    protected virtual void Prompt(string message, int seconds, bool dotted = false, bool countdown = true, bool spinner = false)
    {
        Console.Write(message);
        if (dotted)
        {
            Animation.DottedSpinner(seconds);
        }
        else if (countdown)
        {
            Animation.Countdown(seconds);
        }
        else if (spinner)
        {
            Animation.Spinner(seconds);
        }
        Console.Write("\n");
    }


    public virtual void Done()
    {
        Console.WriteLine("Well done!!");
        Animation.Spinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds the {_name} activity.");
        Animation.Spinner(4);
    }

    public int GetCurrentTime()
    {
        DateTime now = DateTime.Now;
        TimeSpan elapsedTime = now - _startTime;
        return _duration - (int)elapsedTime.TotalSeconds;
    }

    // public int GetNumberOfActivities()
    // {
    //     return _numberOfActivities;
    // }
}