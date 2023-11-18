using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Console.Clear();
        bool endProgram = false;
        List<string> menuOptions = new() { "1. Create New Goal", "2. List Goal", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Exit" };

        var goalList = new List<Goal>();
        int totalPoints = 0;

        while (!endProgram)
        {
            int menuInput;
            // Console.WriteLine("goalList.Count: " + goalList.Count);
            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }
            Console.Write("Select a choice from the menu: ");
            while (!int.TryParse(Console.ReadLine(), out menuInput) || menuInput < 1 || menuInput > 6)
            {
                Console.Write("Select a valid choice from the menu: ");
            }
            switch (menuInput)
            {
                case 1:
                    ProgramFunction.AddGoal(ref goalList);
                    break;
                case 2:
                    ProgramFunction.ListGoals(goalList);
                    break;
                case 3:
                    ProgramFunction.SaveGoals(goalList, totalPoints);
                    break;
                case 4:
                    ProgramFunction.LoadGoals(ref goalList, ref totalPoints);
                    break;
                case 5:
                    ProgramFunction.RecordProgress(ref goalList, ref totalPoints);
                    break;
                case 6:
                    endProgram = true;
                    break;
                default:
                    break;
            }



        }
    }
}