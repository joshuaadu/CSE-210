public enum PromptGeneratorMenu
{
    Write = 1,
    Display,
    Load,
    Save,
    Quit
}

class PromptGenerator
{
    public static string[] _entryQuestions =  {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };





    public static PromptGeneratorMenu GetMenuChoice()
    {

        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
        if (int.TryParse(choice, out int result))
        {
            // if (result > 0 && result < 6)
            // {
            return (PromptGeneratorMenu)result;
            // }
        }
        else
        {
            return 0;
        }
        // return (PromptGeneratorMenu)int.Parse(choice);

    }

    public static Entry PromptEntry()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, 5);
        string prompt = _entryQuestions[index];
        Console.WriteLine(prompt);
        string text = Console.ReadLine();
        DateTime date = DateTime.Now;
        Entry entry = new Entry(text, date, prompt);
        return entry;
    }

    public static string PromptFilename()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        return filename;
    }

}
