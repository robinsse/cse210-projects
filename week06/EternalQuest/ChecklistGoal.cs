using System.Runtime;
using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted += 1;
            Console.WriteLine($"Nice job! Completed: {_amountCompleted} out of {_target} times. ");
            if (IsComplete())
            {
                Console.WriteLine($"Great job! You completed this checklist goal for {_bonus} bonus points! ");
            }
            else
            {
                Console.WriteLine($"You have already completed this goal. ");
            }
        }

    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public void SetComplete(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override string GetDetailsString()
    {
        string checkbox;
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        else
        {
            checkbox = "[ ]";
        }

        return ($"{checkbox} {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}");
    }

    public override string GetStringRepresentation()
    {
        return ($"ChecklistGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus}");
    }
}