public abstract class Activity
{
    private DateTime _date;
    private int _minutes;
    private ActivityType _type;

    public Activity(DateTime date, int minutes, ActivityType type = ActivityType.Activity)
    {
        _type = type;
        _date = date;
        _minutes = minutes;

    }

    public DateTime Date
    {
        get => _date;
        set => _date = value;
    }

    public int Minutes
    {
        get => _minutes;
        set => _minutes = value;
    }


    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMMM yyyy")} {_type} ({_minutes})";
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

}