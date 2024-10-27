public class ChecklistGoal : Goal {
        private int _targetCount;
        private int _currentCount;
        private int _bonusPoints;

        public ChecklistGoal (string name, int points, int targetCount, int bonusPoints) : base(name, points) {

        }

        public override void RecordEvent(){
                
        }

        public override bool IsComplete(){
                return false;
        }

        public override string GetStringRepresentation(){
                return string.Empty;
        }

        public override string GetDetailsString() {
                return string.Empty;
        }
}