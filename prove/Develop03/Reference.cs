class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int? _verseEnd = null;
    private string _reference;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _reference = $"{_book} {_chapter}:{_verseStart}";


    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _reference = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }

    public string GetReference()
    {
        return _reference;
    }
}