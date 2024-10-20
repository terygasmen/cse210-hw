using System;
using System.Collections.Generic;

public abstract class MindfulnessProgram {
        protected string _activityName;
        protected string _activityDescription;
        protected int _activityDuration;

        private static Dictionary<string, int> activityLog = new Dictionary<string, int>{
                {"Breathing Activity", 0},
                {"Reflection Activity", 0},
                {"Listing Activity", 0}
        };

        protected void UpdatedActivityLog() {
                if (activityLog.ContainsKey(_activityName)) {
                        activityLog[_activityName]++;
                }
        }

        public static void DisplayActivityLog() {
                Console.WriteLine("\nActivity Log:");
                foreach (var entry in activityLog) {
                        Console.WriteLine($"{entry.Key}: {entry.Value} times");
                }
                Console.WriteLine();
        }

        public void DisplayStartingMessage() {
                Console.WriteLine($"Starting {_activityName}: {_activityDescription}");
                Console.WriteLine("Enter the duration for this activity (in seconds): ");
                _activityDuration = int.Parse(Console.ReadLine());
                Console.WriteLine("Prepare to begin...");
                ShowSpinner(3);
        }

        public void DisplayEndingMessage() {
                Console.WriteLine("Good job! You completed the activity.");
                Console.WriteLine($"You completed {_activityName} for {_activityDuration} seconds.");
                ShowSpinner(3);

                UpdatedActivityLog();
        }

        protected void ShowSpinner(int seconds) {
                for (int i = 0; i < seconds; i++) {
                        Console.Write("/");
                        Thread.Sleep(500);
                        Console.Write("\b");
                        Console.Write("-");
                        Thread.Sleep(500);
                        Console.Write("\b");
                }
        }

        protected void ShowCountDown(int seconds) {
                for (int i = seconds; i > 0; i--) {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                }
        }

        public abstract void Run();
}