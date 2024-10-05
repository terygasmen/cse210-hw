using System;

public class Program
{
    public static void Main(string[] args){
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", reference);
        
        while (true) {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden()) {
                Console.WriteLine("All words are hidden! Program will now end.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit") {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("Thank you for using the Scripture Memorization Program.");
    }
}