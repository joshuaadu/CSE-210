class ListingActivity : Activity
{
    private List<string> _userList;
    private List<string> _startingMessages = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
        _userList = new List<string>();

    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation.Spinner(4);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Random random = new Random();
        string prompt = _startingMessages[random.Next(_startingMessages.Count)];
        Console.WriteLine($"--- {prompt} ---");
        Prompt("You may begin in: ", 3);

        _startTime = DateTime.Now;
        DateTime endTime = _startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            AddToList();
        }
        Animation.Spinner(2);
        Console.WriteLine($"You listed {_userList.Count} items!");
        Console.WriteLine();
    }

    private void AddToList()
    {
        Console.Write("> ");
        string item = Console.ReadLine();
        _userList.Add(item);
    }

    public void ShowList()
    {
        Console.WriteLine("Here is your list:");
        _userList.ForEach(item => Console.WriteLine(item));

    }
}
