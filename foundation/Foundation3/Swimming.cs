public class Swimming : Activity {
        private int laps;
        private const double LapDistance = 0.05;

        public Swimming(DateTime date, int duration, int laps) : base(date, duration) {
                this.laps = laps;
        }

        public override double GetDistance() => laps * LapDistance;
        public override double GetSpeed() => (GetDistance() / Duration) * 60;
        public override double GetPace() => Duration / GetDistance();
}