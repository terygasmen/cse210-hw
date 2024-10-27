public abstract class Goal {
        public string Name { get; private set;}
        public int Points { get; private set;}
        public bool IsCompleted {get; protected set;}

        protected Goal(string name, int points) {

        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStringRepresentation();

        public string GetDetailsString() {
                return string.Empty;
        }
}