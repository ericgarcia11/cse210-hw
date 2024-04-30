using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2014;
        job1._endYear = 2022;
        // Console.WriteLine(job1._companyName);
        job1.ShowJobInformation();

        Job job2 = new Job();
        job2._companyName = "Apple";
        job2._jobTitle = "Support";
        job2._startYear = 2001;
        job2._endYear = 2023;
        // Console.WriteLine(job2._companyName);
        job2.ShowJobInformation();


        Resume resume1 = new Resume();
        resume1._personName = "Eric Garcia";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.ShowResume();

    }
}