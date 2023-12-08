public class Running: Activity
{
    private double _distance;

    public Running( DateTime date, int minutes, double distance, ActivityType type) : base(date, minutes, type)
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
        return $"{base.GetSummary()} - {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
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