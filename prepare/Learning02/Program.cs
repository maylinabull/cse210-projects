using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Google";
        job2._startYear = 2004;
        job2._endYear = 2009;

        Resume myResume = new Resume();
        myResume._name = "Maylina Bull";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}