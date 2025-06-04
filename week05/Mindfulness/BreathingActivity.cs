using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = Countdown(startTime);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Pause();
            Console.WriteLine("Breathe out...");
            Pause();
        }
    }
}