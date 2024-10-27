using System;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        goalManager.AddGoal(new SimpleGoal("Read a book", 50));
        goalManager.AddGoal(new EternalGoal("Walk 1000 steps", 10));
        goalManager.AddGoal(new ChecklistGoal("Drink 8 glasses of water", 5, 8, 20));

        bool exit = false;
        while (!exit) {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save and Exit");

            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    break;
                case "2":
                    Console.WriteLine("Enter goal name ot record: ");
                    string goalName = Console.ReadLine();
                    goalManager.RecordGoalEvent(goalName);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Current Score: {goalManager.GetTotalScore()}");
                    break;
                case "5":
                    FileManager.SaveGoals("goals.txt", goalManager.GetGoals());
                    exit = true;
                    break;
            }
        }
    }
}