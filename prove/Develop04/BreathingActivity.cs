class BreathingActivity : Activity
{
    private List<string> _messages = new List<string>
    {
        "Breath in...",
        "Breath out..."
    };

    public BreathingActivity(string name, string description) : base(name, description)
    {

    }


    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation.Spinner(4);
        Console.WriteLine();
        Console.WriteLine();

        _startTime = DateTime.Now;
        DateTime endTime = _startTime.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            Prompt(_messages[0], 4);
            Prompt(_messages[1], 6);

            Console.WriteLine();
        }
    }
}


