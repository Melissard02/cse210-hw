using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2013";
        job1._endYear = "2021";
        

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Apple";
        job2._startYear = "1999";
        job2._endYear = "2002";


        Resume myResume = new Resume();
        myResume._name = "Bradley Schmidt";

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);
        // job1.Display();
        // job2.Display();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}