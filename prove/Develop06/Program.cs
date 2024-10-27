using System;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        bool exit = false;
        while (!exit) {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save and Exit");
        }

        string choice = Console.ReadLine();

        switch (choice) {
            case "1":
                break;
            case "2":
                break;
            case "3":
                goalManager.DisplayGoals();
            case "4":
                Console.WriteLine($"Current Score: {goalManager.GetTotalScore()}");
                break;
            case "5":
                exit = true;
                break;
        }
    }
}