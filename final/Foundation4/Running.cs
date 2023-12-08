public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance, ActivityType type) : base(date, minutes, type)
    {
        _distance = distance;
    }

    public double Distance
    {
        get => _distance;
        set => _distance = value;
    }


    public override string GetSummary()
    {
        return $"{base.GetSummary()} - {Double.Round(GetDistance(), 2)} miles, Speed {Double.Round(GetSpeed(), 2)} mph, Pace {Double.Round(GetPace(), 2)} min per mile";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / _distance;
    }
}