class Comment
{
    private string _text;
    public DateTime _date;
    private string _author;

    public Comment(string text, string author)
    {
        _text = text;
        _date = DateTime.Now;
        _author = author;
    }

    
    public string Text
    {
        get => _text;
        set => _text = value;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    public override string ToString()
    {
        return $"{_date} - {Author}: {Text}";
    }
}