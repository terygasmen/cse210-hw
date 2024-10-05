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

                List<int> visibleWordIndices = new List<int>();
                for (int i = 0; i < words.Count; i++) {
                        if (!words[i].IsHidden()) {
                                visibleWordIndices.Add(i);
                        }
                }

                int wordsToHide = Math.Min(numberToHide, visibleWordIndices.Count);

                while (hiddenCount < wordsToHide) {
                        int randomIndex = random.Next(visibleWordIndices.Count);

                        int wordIndex = visibleWordIndices[randomIndex];
                        words[wordIndex].Hide();

                        visibleWordIndices.RemoveAt(randomIndex);

                        hiddenCount++;
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

        public void RevealRandomHiddenWord() {
                Random random = new Random();

                List<int> hiddenWordIndices = new List<int>();
                for (int i = 0; i < words.Count; i++) {
                        if (words[i].IsHidden()) {
                                hiddenWordIndices.Add(i);
                        }
                }

                if (hiddenWordIndices.Count > 0) {
                        int randomIndex = random.Next(hiddenWordIndices.Count);
                        int wordIndex = hiddenWordIndices[randomIndex];
                        words[wordIndex].Show();
                }
        }
}                