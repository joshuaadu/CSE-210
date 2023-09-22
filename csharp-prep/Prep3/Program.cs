using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        bool loop = true;
        int guessCount = 0;
        while (loop)
        {

            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());

            Console.Write("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                loop = false;
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            ++guessCount;
            if (loop == false)
            {

                Console.WriteLine($"You have guessed {guessCount} times.");
                Console.Write("Do you want to play again? (y/n): ");
                string response = Console.ReadLine();
                if (response == "y")
                {
                    loop = true;
                    magicNumber = random.Next(1, 101);
                }
                // else
                // {
                //     loop = false;
                // }
                // loop = false;
            }
        }
        Console.WriteLine($"You have guessed {guessCount} times.");
    }
}