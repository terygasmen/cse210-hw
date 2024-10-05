public class Word {
        private string text;
        private bool isHidden;

        public Word(string text) {
                this.text = text;
                isHidden = false;
        }
        public void Hide(){
                isHidden = true;
        }
        public void Show(){
                isHidden = false;
        }
        public bool IsHidden() {
                return isHidden;
        }
        public string GetDisplayText() {
                if (isHidden) {
                        return new string('_', text.Length);
                } else {
                        return text;
                }
        }
}