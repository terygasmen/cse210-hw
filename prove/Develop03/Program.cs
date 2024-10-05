// Stretch: Added a choice for users to get a hint when memorizing

using System;

public class Program
{
    public static void Main(string[] args){
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", reference);

        while (!scripture.IsCompletelyHidden()) {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress 'Enter' to hide more words, 'H' for a hint, or 'Q' to quit:");
            string input = Console.ReadLine().ToLower();

            if (input == "q") {
                break;
            } else if (input == "h") {
                scripture.RevealRandomHiddenWord();
                Console.WriteLine("Hint used! One hidden word has been revealed.");
            } else {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine("All words are hidden! Scripture memorization complete.");
    }
}