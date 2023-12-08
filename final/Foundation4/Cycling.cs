public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed, ActivityType type) : base(date, minutes, type)
    {
        _speed = speed;
    }


    public override string GetSummary()
    {
        return $"{base.GetSummary()} - {Double.Round(GetDistance(), 2)} miles, Speed {Double.Round(GetSpeed(), 2)} mph, Pace {Double.Round(GetPace(), 2)} min per mile";
    }

    public override double GetDistance()
    {
        return (_speed / 60) * Minutes;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}