using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes"){
            // generate number bet 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber) {
            // ask for a guess
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            guessCount++; //increase guess count
            // check if higher, lower or correct
            if (guess < magicNumber) {
                Console.WriteLine("Higher");
            } else if (guess > magicNumber) {
                Console.WriteLine("Lower");
            } else {
                Console.WriteLine("You guessed it!");
            }
        }

        // ask to play again
        Console.Write("Do you want to play again? (yes/no): ");
        playAgain = Console.ReadLine();
        }
    }
}