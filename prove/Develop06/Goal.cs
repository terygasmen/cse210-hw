public abstract class Goal {
        public string Name { get; private set;}
        public int Points { get; protected set;}
        public bool IsCompleted {get; protected set;}

        protected Goal(string name, int points) {
                Name = name;
                Points = points;
                IsCompleted = false;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStringRepresentation();

        public virtual string GetDetailsString() {
                return $"{Name} - {Points} points";
        }
}