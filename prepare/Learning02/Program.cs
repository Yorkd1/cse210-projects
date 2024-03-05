using System;

class Program
{
    static void Main(string[] args)
    {
        // job1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";
        job1.Display();

        // job2
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";
        job2.Display();

        // Resume
        Resume resume1 = new Resume();
        resume1._name = "David York";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}