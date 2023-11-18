class CheckListGoal : Goal
{
    private int _completionCount;
    private int _requiredCompletionCount;
    private int _completionBonusPoints;

    public CheckListGoal(string goalType, string name, string description, int points, int requiredCompletionCount, int completionBonusPoints) : base(goalType, name, description, points)
    {
        _completionCount = 0;
        _requiredCompletionCount = requiredCompletionCount;
        _completionBonusPoints = completionBonusPoints;

    }

    public int CompletionCount
    {
        get => _completionCount;
        set => _completionCount = value;
    }

    public override void Complete()
    {
        if (!Completed && _completionCount < _requiredCompletionCount)
        {
            _completionCount++;
            if (_completionCount == _requiredCompletionCount)
            {
                Points += _completionBonusPoints;
                base.Complete();
            }
        }
    }

    public new static Dictionary<string, string> Prompt()
    {
        Dictionary<string, string> prompt = Goal.Prompt();
        int requiredCompletionCount;
        int completionBonusPoints;
        Console.Write("How many times does this goal need to be completed for a bonus? ");
        while (!int.TryParse(Console.ReadLine(), out requiredCompletionCount) || requiredCompletionCount < 1)
        {
            Console.Write("Enter a valid number of times you need to complete the goal: ");
        }
        Console.Write("What is the bonus for accomplishing it that many times? ");
        while (!int.TryParse(Console.ReadLine(), out completionBonusPoints) || completionBonusPoints < 1)
        {
            Console.Write("Enter a valid number of bonus points you get for completing the goal: ");
        }
        prompt.Add("requiredCompletionCount", requiredCompletionCount.ToString());
        prompt.Add("completionBonusPoints", completionBonusPoints.ToString());
        return prompt;
    }

    public override string Display()
    {
        return base.Display() + $" -- Currently completed: {_completionCount}/{_requiredCompletionCount}";
    }

    public override string ToString()
    {
        return base.ToString() + string.Format(", {0}, {1}, {2}", _completionCount, _requiredCompletionCount, _completionBonusPoints);
    }
}