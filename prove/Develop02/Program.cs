using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool quit = false;
        while (!quit)
        {
            PromptGeneratorMenu choice = PromptGenerator.GetMenuChoice();
            switch (choice)
            {
                case PromptGeneratorMenu.Write:
                    Entry entry = PromptGenerator.PromptEntry();
                    journal.Add(entry);
                    break;
                case PromptGeneratorMenu.Display:
                    journal.Display();
                    break;
                case PromptGeneratorMenu.Load:
                    journal.Load();
                    break;
                case PromptGeneratorMenu.Save:
                    journal.Save();
                    break;
                case PromptGeneratorMenu.Quit:
                    quit = journal.Quit();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}