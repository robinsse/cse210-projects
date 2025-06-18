public class Running : Activity
{
    private double _distance; //in miles

    public Running(DateTime date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override string ActivityType()
    {
        return "Running";
    }
}