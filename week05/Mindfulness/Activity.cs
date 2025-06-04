using System.Reflection.Metadata;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string _textDuration = Console.ReadLine();
        _duration = int.Parse(_textDuration);
    }

    public void EndingMessage()
    {
        Console.WriteLine("Great job being mindful!");
        Console.WriteLine();
    }

    public void Pause()
    {
        Console.WriteLine("Get ready...");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine(" ");
    }

    public DateTime Countdown(DateTime startTime)
    {
        return startTime.AddSeconds(_duration);
    }
}