using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BYU Independent Study";
        job1._jobTitle = "Graphic Designer";
        job1._startYear = 2002;
        job1._endYear = 2003;

        Job job2 = new Job();
        job2._company = "BYU-Idaho";
        job2._jobTitle = "Online Curriculum Designer";
        job2._startYear = 2019;
        job2._endYear = 2025;

        // job1.Display();
        // job2.Display();

        Resume name1 = new Resume();
        name1._name = "Selena Robins";

        name1._jobs.Add(job1);
        name1._jobs.Add(job2);

        name1.Display();
    }
}