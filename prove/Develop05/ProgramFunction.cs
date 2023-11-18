class ProgramFunction
{
    public static void AddGoal(ref List<Goal> goalList)
    {
        int goalType;
        List<string> goalTypes = new() { "1. Simple Goal", "2. Eternal Goal", "3. Check List Goal", };

        foreach (string goal in goalTypes)
        {
            Console.WriteLine(goal);
        }

        Console.Write("Which type of goal would you like to create? ");

        while (!int.TryParse(Console.ReadLine(), out goalType) || goalType < 1 || goalType > 3)
        {
            Console.Write("Enter a valid number for appropriate goal type: ");
        }

        switch (goalType)
        {
            case 1:
                Dictionary<string, string> goal = Goal.Prompt();
                goalList.Add(new Goal("Simple", goal["name"], goal["description"], int.Parse(goal["points"])));
                break;

            case 2:
                Dictionary<string, string> eternalGoal = Goal.Prompt();
                goalList.Add(new EternalGoal("Eternal", eternalGoal["name"], eternalGoal["description"], int.Parse(eternalGoal["points"])));
                break;

            case 3:
                Dictionary<string, string> checkListGoal = CheckListGoal.Prompt();
                goalList.Add(new CheckListGoal("CheckList", checkListGoal["name"], checkListGoal["description"], int.Parse(checkListGoal["points"]), int.Parse(checkListGoal["requiredCompletionCount"]), int.Parse(checkListGoal["completionBonusPoints"])));
                break;

            default:
                break;
        }
        Console.WriteLine("Goal added! ");
    }

    public static void ListGoals(List<Goal> goalList)
    {
        Console.WriteLine("Goals List:");
        int goalNumber = 1;

        foreach (Goal goal in goalList)
        {
            Console.WriteLine(string.Format("{0}. [{1}] {2}", goalNumber, goal.Completed ? 'X' : ' ', goal.Display()));
            ++goalNumber;
        }
    }



    public static void SaveGoals(List<Goal> goalList, int totalPoints)
    {
        Console.Write("Enter the name of the file you want to save to: ");
        string fileName = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.WriteLine($"Points, {totalPoints}");

            foreach (Goal goal in goalList)
            {
                sw.WriteLine(goal.ToString());
            }
        }
    }

    public static void LoadGoals(ref List<Goal> goalList, ref int totalPoints)
    {
        Console.Write("Enter the name of the file you want to load from: ");
        string fileName = Console.ReadLine();

        using (StreamReader sr = new StreamReader(fileName))
        {
            goalList.Clear();
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] goalData = line.Split(",");

                switch (goalData[0])
                {
                    case "Points":
                        totalPoints = int.Parse(goalData[1]);
                        break;

                    case "Simple":
                        Goal simpleGoal = new Goal(goalData[0], goalData[1], goalData[2], int.Parse(goalData[3]));
                        simpleGoal.StartTime = DateTime.Parse(goalData[4]);
                        simpleGoal.EndTime = DateTime.Parse(goalData[5]);
                        simpleGoal.Completed = bool.Parse(goalData[6]);

                        goalList.Add(simpleGoal);
                        break;

                    case "Eternal":
                        EternalGoal eternalGoal = new EternalGoal(goalData[0], goalData[1], goalData[2], int.Parse(goalData[3]));
                        eternalGoal.StartTime = DateTime.Parse(goalData[4]);
                        eternalGoal.EndTime = DateTime.Parse(goalData[5]);
                        eternalGoal.Completed = bool.Parse(goalData[6]);

                        goalList.Add(eternalGoal);
                        break;

                    case "CheckList":
                        CheckListGoal checklistGoal = new CheckListGoal(goalData[0], goalData[1], goalData[2], int.Parse(goalData[3]), int.Parse(goalData[8]), int.Parse(goalData[9]));
                        checklistGoal.StartTime = DateTime.Parse(goalData[4]);
                        checklistGoal.EndTime = DateTime.Parse(goalData[5]);
                        checklistGoal.Completed = bool.Parse(goalData[6]);
                        checklistGoal.CompletionCount = int.Parse(goalData[7]);

                        goalList.Add(checklistGoal);
                        break;

                    default:
                        break;
                }
            }
        }
    }

    public static void RecordProgress(ref List<Goal> goalList, ref int totalPoints)
    {
        Console.Write("Which goal did you accomplish? ");
        int goalNumber;

        while (!int.TryParse(Console.ReadLine(), out goalNumber) || goalNumber < 1 || goalNumber > goalList.Count)
        {
            Console.Write("Enter a valid number for the goal you accomplished: ");
        }

        Goal goal = goalList[goalNumber - 1];

        if (goal.Completed)
        {
            Console.WriteLine("You have already completed this goal.");
        }
        else
        {
            goal.Complete();
            totalPoints += goal.Points;
        }
    }
}
