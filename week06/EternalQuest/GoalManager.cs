using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(int score)
    {
        _score = score;
    }

    public void Start()
    {
        string menu = "";
        while (menu != "6")
        {
            Console.WriteLine();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goal");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record");
            Console.WriteLine("6. Quit");
            menu = Console.ReadLine();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You currently have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        string goalType = "";
        while (goalType != "1" && goalType != "2" && goalType != "3")
        {
            Console.WriteLine("Type of Goal:");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Eternal");
            Console.WriteLine("3. Checklist");
            goalType = Console.ReadLine();
            Console.WriteLine("Give your goal a brief title: ");
            string title = Console.ReadLine();
            Console.WriteLine("What is the description of this goal?");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is this goal worth?");
            int points = int.Parse(Console.ReadLine());

            if (goalType == "1")
            {
                Goal goal = new SimpleGoal(title, description, points);
                _goals.Add(goal);
            }

            else if (goalType == "2")
            {
                Goal goal = new EternalGoal(title, description, points);
                _goals.Add(goal);
            }

            else if (goalType == "3")
            {
                Console.WriteLine("How many times do you want to complete this goal? ");
                int times = int.Parse(Console.ReadLine());
                Console.WriteLine("How many bonus points is it worth? ");
                int bonus = int.Parse(Console.ReadLine());

                Goal goal = new ChecklistGoal(title, description, points, times, bonus);
                _goals.Add(goal);
            }

            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.WriteLine("Which goal have you completed? ");
        string goalCompleted = Console.ReadLine();
        int i = int.Parse(goalCompleted) - 1;

        if (i >= 0 && i < _goals.Count)
        {
            Goal goal = _goals[i];
            bool wasComplete = goal.IsComplete();
            goal.RecordEvent();
            _score += goal.GetPoints();

            if (!wasComplete && goal.IsComplete() && goal is ChecklistGoal checklistGoal)
            {
                _score += checklistGoal.GetBonus();
            }

            DisplayPlayerInfo();
        }
        else
        {
            Console.WriteLine("This is not a valid selection.");
        }
    }

    public void SaveGoals()
    {
        string filename = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Your goals have been saved. ");
    }

    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        _goals.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.SetComplete(isComplete);
                _goals.Add(goal);
            }

            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }

            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                goal.SetComplete(amountCompleted);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals successfully loaded. ");
    }
}