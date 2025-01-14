using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";
        
        while (playAgain.ToLower() == "yes")
        {
            // Step 1: Generate a random magic number between 1 and 100
            Random rand = new Random();
            int magicNumber = rand.Next(1, 101);

            // Step 2: Start the guessing loop
            int guess = -1; // Initialize guess with a non-matching value
            int guessCount = 0; // To count the number of guesses

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}

