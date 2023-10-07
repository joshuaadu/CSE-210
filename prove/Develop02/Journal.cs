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

    public void Save(string filename)
    {
        FileOperations.save(filename, _entries);
    }

    public void Load(string filename)
    {
        _entries.Clear();
        FileOperations.load(filename, ref _entries);


    }

    public bool Quit()
    {
        return true;
    }

}
