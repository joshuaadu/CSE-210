class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";
    public MathAssignment(string studenName, string topic, string textbookSection, string problem) : base(studenName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problem}";
    }
}