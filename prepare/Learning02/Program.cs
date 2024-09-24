using System;

class Program
{
    static void Main(string[] args)
    {
        // job instance 1st
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // job instance 2nd
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // job1.Display();
        // job2.Display();

        // creates new resume
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // adding job to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}