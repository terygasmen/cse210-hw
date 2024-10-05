using System;
using System.Collections.Generic;

public class Scripture {
        private Reference reference;
        private List<Word> words;

        public Scripture(string scriptureText, Reference reference) {
                this.reference = reference;
                words = new List<Word>();

                string[] wordArray = scriptureText.Split(' ');
                foreach (string word in wordArray) {
                        words.Add(new Word(word));
                }
        }
        public void HideRandomWords(int numberToHide) {
                Random random = new Random();
                int hiddenCount = 0;

                while (hiddenCount < numberToHide) {
                        int index = random.Next(words.Count);

                        if (!words[index].IsHidden()) {
                                words[index].Hide();
                                hiddenCount++;
                        }
                }
        }
        public string GetDisplayText() {
                string displayText = reference.GetDisplayText() + "\n";

                foreach (Word word in words) {
                        displayText += word.GetDisplayText() + " ";
                }

                return displayText.Trim();
        }
        public bool IsCompletelyHidden() {
                foreach (Word word in words) {
                        if (!word.IsHidden()) {
                                return false;
                        }
                }
                return true;
        }
}