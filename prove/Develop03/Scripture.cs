class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ConvertTextToWords(text);
    }

    static public List<Word> ConvertTextToWords(string text)
    {
        string[] wordsArray = text.Split(' ');

        List<Word> words = new List<Word>(wordsArray.Select(word => new Word(word)));
        return words;
    }

    public string GetText()
    {
        string text = "";
        _words.ForEach(word => text += word.GetWord() + " ");
        return text;
    }

    public string GetReference()
    {
        return _reference.GetReference();
    }

    public int HideWord()
    {
        // List<_words> remainingWords = _words.FindAll(w => w.GetWord() != "_");
        List<Word> remainingWords = _words.Where(w => w.IsHidden() != true).ToList();
        while (remainingWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(0, _words.Count);
            if (_words[index].IsHidden())
            {
                continue;
            }
            else
            {
                _words[index].Hide();
                break;
            }
        }
        return remainingWords.Count;
        // _words.Find(w => w.GetWord() == word).Hide();
    }
}