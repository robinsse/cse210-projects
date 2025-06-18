using System.ComponentModel.DataAnnotations;

public class Biking : Activity
{
    private double _speed; //in miles per hour

    public Biking(DateTime date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed / 60 * GetLength();
    }

    public override string ActivityType()
    {
        return "Biking";
    }
}