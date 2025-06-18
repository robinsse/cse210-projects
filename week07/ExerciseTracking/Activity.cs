public abstract class Activity
{
    private DateTime _date;
    private double _length; //in minutes

    public Activity(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }

    public double GetLength()
    {
        return _length;
    }
    public abstract double GetDistance();
    public double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public double GetPace()
    {
        return 60 / GetSpeed();
    }

    public abstract string ActivityType();

    public void GetSummary()
    {
        Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {ActivityType()} ({_length} min)- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile");
    }
}