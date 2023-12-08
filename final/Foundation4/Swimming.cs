public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps, ActivityType type) : base(date, minutes, type)
    {
        _laps = laps;
    }



    public override string GetSummary()
    {
        return $"{base.GetSummary()} - {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}
