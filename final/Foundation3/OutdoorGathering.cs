public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, EventType type, string weather) : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    public string Weather
    {
        get => _weather;
        set => _weather = value;
    }

    public string Details()
    {
        return $@"
        Full Details
--------------------------------
{base.ToString()},
Weather: {Weather}";
    }
}