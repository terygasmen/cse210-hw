public class SimpleGoal : Goal {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent() {
                
        }

        public override bool IsComplete(){
                return false;
        }

        public override string GetStringRepresentation() {
                return string.Empty;
        }
}