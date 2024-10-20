using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessProgram {
        private List<string> _listingPrompts = new List<string> {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "Who are some of your personal heroes?"
        };
        
        public ListingActivity(){
                _activityName = "Listing Activity";
                _activityDescription = "This activity will help you reflect on the good things in your life by listing items.";
        }

        public override void Run(){
                DisplayStartingMessage();

                Random random = new Random();
                string prompt = _listingPrompts[random.Next(_listingPrompts.Count)];
                Console.WriteLine(prompt);
                ShowCountDown(3);

                List<string> items = new List<string>();
                Console.WriteLine("Start listing item:");

                DateTime endTime = DateTime.Now.AddSeconds(_activityDuration);
                while (DateTime.Now < endTime) {
                        string input = Console.ReadLine();
                        if (!string.IsNullOrEmpty(input)) {
                                items.Add(input);
                        }
                }

                Console.WriteLine($"You listed {items.Count} items.");
                DisplayEndingMessage();
        }
}
