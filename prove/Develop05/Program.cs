using System;

class Program {
        static void Main(string[] args)
        {
                while (true) {
                        Console.Clear();
                        Console.WriteLine("Choose an activity:");
                        Console.WriteLine("1. Breathing Activity");
                        Console.WriteLine("2. Reflection Activity");
                        Console.WriteLine("3. Listing Activity");
                        Console.WriteLine("4. View Activity Log");
                        Console.WriteLine("5. Quit");

                        string choice = Console.ReadLine(); 

                        MindfulnessProgram activity = null;
                        switch (choice) {
                                case "1":
                                        activity = new BreathingActivity();
                                        break;
                                case "2":
                                        activity = new ReflectionActivity();
                                        break;
                                case "3":
                                        activity = new ListingActivity();
                                        break;
                                case "4":
                                        MindfulnessProgram.DisplayActivityLog();
                                        Console.WriteLine("Press any key to return to the main menu...");
                                        Console.ReadKey();
                                        continue;
                                default:
                                        Console.WriteLine("Invalid choice. Try again.");
                                        continue;
                        }

                        activity.Run();
                }
        }
}