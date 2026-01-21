using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Cloud Engineer";
        job2._company = "Amazon";
        job2._startYear = 2023;
        job2._endYear = 2025;


        Resume myResume = new Resume();
        myResume._name = "Ikechukwu Great";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display(); 
    }
}