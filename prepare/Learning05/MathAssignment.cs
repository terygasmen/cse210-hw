public class MathAssignment : Assignment {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string studentName, string topic, string _textbookSection, string problems) 
                : base(studentName, topic) {
                        _textbookSection = _textbookSection;
                        _problems = problems;
                }

        public string GetHomeworkList() {
                return $"Section {_textbookSection}  Problems {_problems}";
        }
}