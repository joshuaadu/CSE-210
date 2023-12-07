public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, EventType type, string speaker, string capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string Speaker
    {
        get => _speaker;
        set => _speaker = value;
    }

    public string Capacity
    {
        get => _capacity;
        set => _capacity = value;
    }



    public string Details()
    {
        return $@"
        Full Details
--------------------------------
{base.ToString()},
Speaker: {Speaker}, 
Capacity: {Capacity}";
    }
}