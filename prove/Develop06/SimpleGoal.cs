public class SimpleGoal : Goal {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent() {
                if (!IsCompleted) {
                        IsCompleted = true;
                }
        }

        public override bool IsComplete(){
                return IsCompleted;
        }

        public override string GetStringRepresentation() {
                return $"SimpleGoal:{Name}, {Points}, {IsCompleted}";
        }
}