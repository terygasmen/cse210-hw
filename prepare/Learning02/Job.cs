public class Job {

        // fields
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        // displaying in format
        public void Display(){
                Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}