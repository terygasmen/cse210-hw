using System;

class Program {

    public static void EditJournalEntry(Journal myJournal) {
        Console.WriteLine("Journal Entries:");
        myJournal.DisplayJournal();

        Console.Write("Enter the number of the entry you want to edit: ");
        int entryIndex;
        if (int.TryParse(Console.ReadLine(), out entryIndex) && entryIndex >= 1 && entryIndex <= myJournal.GetEntryCount()) {
            entryIndex -= 1;
            Console.Write("Enter the new prompt: ");
            string newPrompt = Console.ReadLine();
            Console.Write("Enter the new response: ");
            string newResponse = Console.ReadLine();
            myJournal.EditEntry(entryIndex, newPrompt, newResponse);
        } else {
            Console.WriteLine("Invalid entry number.");
        }
    }
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
            Console.WriteLine("5. Edit an entry");
            Console.WriteLine("6. Quit");
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
                    EditJournalEntry(myJournal);
                    break;
                case "6":
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