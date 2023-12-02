class Goal
{
    private string _name;
    private string _description;
    private DateTime _startTime;
    private DateTime _endTime;
    private int _points;
    private bool _completed;
    private string _goalType;

    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _startTime = DateTime.Now;
        _points = points;
        _completed = false;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Description
    {
        get => _description;
        set => _description = value;
    }

    public DateTime StartTime
    {
        get => _startTime;
        set => _startTime = value;
    }

    public DateTime EndTime
    {
        get => _endTime;
        set => _endTime = value;
    }

    public int Points
    {
        get => _points;
        set => _points = value;
    }

    public bool Completed
    {
        get => _completed;
        set => _completed = value;
    }

    public virtual void Complete()
    {
        _completed = true;
        _endTime = DateTime.Now;
    }

    public virtual string Display()
    {
        return $"{_name} ({_description})";
    }
    public new virtual string ToString()
    {
        return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", _goalType, _name, _description, _points, _startTime, _endTime, _completed);
    }

    public static Dictionary<string, string> Prompt()
    {
        Dictionary<string, string> prompt = new Dictionary<string, string>();
        Console.Write("What is the name for the goal: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points) || points < 1)
        {
            Console.Write("Enter a valid point value for the goal: ");
        }
        prompt.Add("name", name);
        prompt.Add("description", description);
        prompt.Add("points", points.ToString());
        return prompt;
    }

}