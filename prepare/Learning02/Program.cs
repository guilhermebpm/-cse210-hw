using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Frontend Developer";
        job1._company = "Apple";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "BYU";
        job2._startYear = 2019;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Guilherme Melo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}