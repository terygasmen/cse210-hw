using System;
using System.IO;
using System.Collections.Generic;

public static class FileManager {
        public static void SaveGoals (string filePath, List<Goal> goals) {
                using (StreamWriter writer = new StreamWriter(filePath)) {
                        foreach (var goal in goals) {
                                writer.WriteLine(goal.GetStringRepresentation());
                        }
                }
        }

        public static List<Goal> LoadGoals(string filePath) {
                List<Goal> goals = new List<Goal>();

                if (File.Exists(filePath)) {
                        using (StreamReader reader = new StreamReader(filePath)) {
                                string line;
                                while ((line = reader.ReadLine()) != null) {
                                        string[] parts = line.Split(':');
                                        string type = parts[0];
                                        string[] parameters = parts[1].Split(',');

                                        switch (type) {
                                                case "SimpleGoal":
                                                        goals.Add(new SimpleGoal(parameters[0], int.Parse(parameters[1])));
                                                        break;
                                                case "EternalGoal":
                                                        goals.Add(new EternalGoal(parameters[0], int.Parse(parameters[1])));
                                                        break;
                                                case "ChecklistGoal":
                                                        goals.Add(new ChecklistGoal(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[4])));
                                                        break;
                                        }
                                }
                        }
                }

                return goals;
        }
}