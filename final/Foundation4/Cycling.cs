public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed, ActivityType type) : base(date, minutes, type)
    {
        _speed = speed;
    }


    public override string GetSummary()
    {
        return $"{base.GetSummary()} - {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
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