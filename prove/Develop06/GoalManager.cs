using System;
using System.Collections.Generic;

public class GoalManager {
        private List<Goal> goals;
        private int totalScore;

        public GoalManager() {
                goals = new List<Goal>();
                totalScore = 0;
        }

        public void AddGoal(Goal goal) {
                goals.Add(goal);
        }

        public void RecordGoalEvent (string goalName) {
                Goal goal = goals.Find(g => g.Name == goalName);
                if (goal != null) {
                        goal.RecordEvent();
                        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete()){
                                totalScore += goal.Points + checklistGoal.BonusPoints;
                        } else {
                                totalScore += goal.Points;
                        }
                }
        }

        public void DisplayGoals() {
                foreach (var goal in goals) {
                        Console.WriteLine(goal.GetDetailsString());
                }
        }
        public int GetTotalScore() {
                return totalScore;
        }

        public List<Goal> GetGoals() {
                return goals;
        }
}