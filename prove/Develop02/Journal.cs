using System;
using System.Collections.Generic;
using System.IO;

public class Journal {

        public int GetEntryCount() {
                return _entries.Count;
        }
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(string prompt) {
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(prompt, response, date);
                _entries.Add(newEntry);
        }

        public void DisplayJournal() {
                foreach (Entry entry in _entries) {
                        entry.Display();
                }
        }

        public void EditEntry(int entryIndex, string newPrompt, string newResponse) {
                if (entryIndex >= 0 && entryIndex < _entries.Count) {
                        _entries[entryIndex].EditEntry(newPrompt, newResponse);
                        Console.WriteLine("Entry updated successfully.");
                } else {
                        Console.WriteLine("Invalid entry number.");
                }
        }

        public void SaveJournal(string filename) {
                using (StreamWriter writer = new StreamWriter(filename)) {
                        foreach (Entry entry in _entries) {
                                writer.WriteLine(entry.FormatForFile());
                        }
                }
                Console.WriteLine("Journal saved.");
        }

        public void LoadJournal(string filename) {
                _entries.Clear();
                if (File.Exists(filename)){
                        string[] lines = File.ReadAllLines(filename);
                        foreach (string line in lines) {
                                string[] parts = line.Split('|');
                                string date = parts[0];
                                string prompt = parts[1];
                                string response = parts[2];
                                Entry entry = new Entry(prompt, response, date);
                                _entries.Add(entry);
                        }
                        Console.WriteLine("Journal loaded.");
                } else {
                        Console.WriteLine("File not found.");
                }
        }
}