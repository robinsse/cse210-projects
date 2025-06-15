public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Nice job! This goal is complete. ");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override string GetStringRepresentation()
    {
        return ($"SimpleGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}");
    }
}