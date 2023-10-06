using System;

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void Add(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine();
        }
    }

    public void Save()
    {
        File.save("test.txt", _entries);
    }

    public void Load()
    {
        _entries.Clear();
        File.load("test.txt", _entries);


    }

    public bool Quit()
    {
        return true;
    }

}
