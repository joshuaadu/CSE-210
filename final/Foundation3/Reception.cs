public class Reception: Event
{
    private string _email;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, EventType type, string email) : base(title, description, date, time, address, type)
    {
        _email = email;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    public string Details()
    {
        return $@"
        Full Details
--------------------------------
{base.ToString()},
RSVP: {Email}";
    }

}