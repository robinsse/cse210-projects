public class ReflectingActivity : Activity
{
    private List<string> _reflectingPrompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _question = new List<string>
    {
       "Why was this experience meaningful to you?",
       "Have you ever done anything like this before?",
       "How did you get started?",
       "How did you feel when it was complete?",
       "What made this time different than other times when you were not as successful?",
       "What is your favorite thing about this experience?",
       "What could you learn from this experience that applies to other situations?",
       "What did you learn about yourself through this experience?",
       "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = Countdown(startTime);

        SelectPrompt();
        Pause();

        while (DateTime.Now < endTime)
        {
            SelectQuestion();
            Pause();
        }
    }

    public void SelectPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_reflectingPrompt.Count);
        Console.WriteLine($" --- {_reflectingPrompt[randomIndex]} --- ");
    }

    public void SelectQuestion()
    {
        Random _random = new Random();
        int randomIndex = _random.Next(_question.Count);
        Console.WriteLine(_question[randomIndex]);
        string reflection = Console.ReadLine();
    }
}