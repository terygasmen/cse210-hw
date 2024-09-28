using System;

class Program {
    static void Main(string[] args) {
        Journal myJournal = new Journal();
        Random random = new Random();

        List<string> prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool running = true;

        while (running) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    string prompt = prompts[random.Next(prompts.Count)];
                    myJournal.AddEntry(prompt);
                    break;
                case "2":
                    myJournal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveJournal(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter the filename to load the journal: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadJournal(loadFilename);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}