using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessProgram {
        private List<string> _reflectionPrompts = new List<string> {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
        };
        private List<string> _reflectionQuestions = new List<string> {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What did you learn about yourself through this experience?"
        };

        public ReflectionActivity() {
                _activityName = "Reflection Activity";
                _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
        }

        public override void Run(){
                DisplayStartingMessage();

                Random random = new Random();
                string prompt = _reflectionPrompts[random.Next(_reflectionPrompts.Count)];
                ShowSpinner(3);

                for (int i = 0; i < _activityDuration / 10; i++) {
                        string question = _reflectionQuestions[random.Next(_reflectionQuestions.Count)];
                        Console.WriteLine(question);
                        ShowSpinner(5);
                }

                DisplayEndingMessage();
        }
}