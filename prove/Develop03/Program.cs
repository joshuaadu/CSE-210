using System;
// using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Reference reference;
        Console.WriteLine("Hello Develop03 World!");
        bool endProgram = false;
        string book = "";
        int chapter;
        int verse;
        int? endVerse = null;
        string text = "";

        Console.WriteLine("Follow the prompt to memorize a scripture.");
        while (!endProgram)
        {
            Console.Clear();
            Console.WriteLine("Enter the reference of the scripture you want to memorize.");
            Console.Write("Book: ");
            book = Console.ReadLine();
            Console.Write("Chapter: ");
            chapter = Int32.Parse(Console.ReadLine());
            Console.Write("Verse: ");
            verse = Int32.Parse(Console.ReadLine());
            Console.Write("Do you want to add an end verse? (y/n): ");
            string addEndVerse = Console.ReadLine();
            if (addEndVerse == "y" || addEndVerse == "Y")
            {
                Console.Write("End Verse: ");
                endVerse = Int32.Parse(Console.ReadLine());
            }
            // Console.WriteLine(endVerse);
            Console.Write("Text: ");
            text = Console.ReadLine();
            if (endVerse != null)
            {
                reference = new Reference(book, chapter, verse, (int)endVerse);
            }
            else
            {
                reference = new Reference(book, chapter, verse);
            }

            Scripture scripture = new Scripture(reference, text);
            Console.Clear();
            Console.WriteLine(scripture.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine();

            bool isHideWord = true;
            while (isHideWord)
            {
                Console.Write("Press enter to continue or type 'q' to quit: ");
                string hideWord = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(hideWord))
                {
                    Console.Clear();
                    int count = scripture.HideWord();
                    Console.WriteLine(scripture.GetReference());
                    Console.WriteLine(scripture.GetText());
                    Console.WriteLine();
                    if (count == 1)
                    {
                        isHideWord = false;
                    }
                }
                else if (hideWord == "q")
                {
                    endProgram = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

            }

            bool addNewScripture = true;
            while (addNewScripture)
            {
                Console.Write("Do you want to memorize another scripture? (y/n) ");
                string startAgain = Console.ReadLine();

                switch (startAgain)
                {
                    case "y":
                        addNewScripture = false;
                        break;
                    case "n":
                        addNewScripture = false;
                        endProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

    }
}