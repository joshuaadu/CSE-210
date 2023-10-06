
class Entry
{
    public string content { get; set; }
    public DateTime date { get; set; }
    public string prompt { get; set; }

    public Entry(string content, DateTime date, string prompt)
    {
        this.content = content;
        this.date = date;
        this.prompt = prompt;
    }

    public override string ToString()
    {
        return $"Date:  {date.ToString()} - Prompt: {prompt} \n{content}";
    }
}