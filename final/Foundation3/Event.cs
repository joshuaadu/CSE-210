public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;
    private EventType _type;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address, EventType type)
    {
        _title = title;
        _description = description;
        _date = date.Date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public string Description
    {
        get => _description;
        set => _description = value;
    }

    public DateTime Date
    {
        get => _date;
        set => _date = value;
    }

    public TimeSpan Time
    {
        get => _time;
        set => _time = value;
    }

    public Address Address
    {
        get => _address;
        set => _address = value;
    }

    public EventType Type
    {
        get => _type;
        set => _type = value;
    }

    public override string ToString()
    {
        return $@"  
Title: {Title},
Description: {Description}, 
Date: {Date.ToShortDateString()}, 
Time: {Time}, 
Address: {Address},
Type: {Type}";
    }

    public string ShortDescription()
    {
        return $@"
        Short Description
----------------------------
Type: {Type}
Title: {Title},
Date: {Date.ToShortDateString()}";
    }

}