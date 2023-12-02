class Video
{
    private string _title;
    private string _description;
    private string _url;
    private int _length;
    private string _author;

    private List<Comment> _comments;

    public Video(string title, string description, string url, int length, string author)
    {
        _title = title;
        _description = description;
        _url = url;
        _length = length;
        _author = author;
        _comments = new List<Comment>();
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

    public string Url
    {
        get => _url;
        set => _url = value;
    }

    public int Length
    {
        get => _length;
        set => _length = value;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    public List<Comment> Comments
    {
        get => _comments;
        set => _comments = value;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} ({Length} seconds)\n{Description}\n{Url}\n Comments: {GetNumberOfComments()}";
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayComments()
    {
        foreach (Comment comment in Comments)
        {
            Console.WriteLine(comment);
        }
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}