public class Swimming : Activity
{
    private double _laps; //minutes per mile

    public Swimming(DateTime date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override string ActivityType()
    {
        return "Swimming";
    }

}