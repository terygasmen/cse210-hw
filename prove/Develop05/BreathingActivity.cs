using System;

public class BreathingActivity : MindfulnessProgram {
        public BreathingActivity() {
                _activityName = "Breathing Activity";
                _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly.";
        }

        public override void Run(){
                DisplayStartingMessage();

                int timePerBreath = _activityDuration / 2;

                for (int i = 0; i < timePerBreath; i++) {
                        Console.WriteLine("Breathe in...");
                        ShowCountDown(4);
                        Console.WriteLine("Breathe out...");
                        ShowCountDown(4);
                }

                DisplayEndingMessage();
        }
}