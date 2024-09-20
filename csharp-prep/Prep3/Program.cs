using System;

class Program
{
    static void Main(string[] args)
    {
        // generate number bet 1 and 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber) {
            // ask for a guess
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            // check if higher, lower or correct
            if (guess < magicNumber) {
                Console.WriteLine("Higher");
            } else if (guess > magicNumber) {
                Console.WriteLine("Lower");
            } else {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}