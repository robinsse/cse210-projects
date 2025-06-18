using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running running = new Running(new DateTime(2025, 6, 17), 35, 3.5);
        Biking biking = new Biking(new DateTime(2025, 3, 8), 55, 10);
        Swimming swimming = new Swimming(new DateTime(2025, 4, 15), 60, 60);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(biking);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}