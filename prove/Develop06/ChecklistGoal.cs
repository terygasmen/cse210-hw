public class ChecklistGoal : Goal {
        private int _targetCount;
        private int _currentCount;
        private int _bonusPoints;

        public ChecklistGoal (string name, int points, int targetCount, int bonusPoints) : base(name, points) {
                _targetCount = targetCount;
                _currentCount = 0;
                _bonusPoints = bonusPoints;
        }

        public int BonusPoints {
                get { return _bonusPoints;}
        }

        public override void RecordEvent(){
                if (_currentCount < _targetCount) {
                        _currentCount++;
                        if (_currentCount == _targetCount) {
                                IsCompleted = true;
                        }
                }
        }

        public override bool IsComplete(){
                return _currentCount >= _targetCount;
        }

        public override string GetStringRepresentation(){
                return $"ChecklistGoal:{Name},{Points},{_targetCount},{_currentCount},{_bonusPoints}";
        }

        public override string GetDetailsString() {
                return $"{Name} - Completed {_currentCount}/{_targetCount} times - {Points} points";
        }
}