class ReflectionActivity : Activity
{
    private List<string> _startingMessages = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation.Spinner(4);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");

        Random random = new Random();
        string prompt = _startingMessages[random.Next(_startingMessages.Count)];
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        {
        } // Wait for user to press enter

        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Prompt("You may begin in: ", 3);
        _startTime = DateTime.Now;
        DateTime endTime = _startTime.AddSeconds(_duration);

        List<string> questions = new List<string>(_questions);
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            string question = questions[random.Next(questions.Count)];
            Prompt(message: $"> {question} ", seconds: 5);
            questions.Remove(question);
            if (questions.Count == 0)
            {
                questions = new List<string>(_questions);
            }
        }
    }
}
