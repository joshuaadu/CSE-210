using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
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
                    journal.Load(PromptGenerator.PromptFilename());
                    break;
                case PromptGeneratorMenu.Save:
                    journal.Save(PromptGenerator.PromptFilename());
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