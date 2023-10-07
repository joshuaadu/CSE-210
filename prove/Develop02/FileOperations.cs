using System.IO;
using System;

class FileOperations
{


    static public void load(string filename, ref List<Entry> entries)
    {
        // File.exists();
        /*
        *...
        */
        if (File.Exists(filename))
        {
            foreach (string line in File.ReadLines(filename))
            {
                if (line == "")
                {
                    continue;
                }
                string[] parts = line.Split('|');
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string content = parts[2];
                Entry entry = new Entry(content, date, prompt);
                entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File does not exist");
        }

    }


    public static void save(string filename, List<Entry> entries)
    {
        // File.exists();
        /*
        *...
        */
        if (!File.Exists(filename))
        {
            File.Delete(filename);
        }

        try
        {

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    outputFile.WriteLine($"{entry.date}|{entry.prompt}|{entry.content}");
                }


            }
        }
        catch (System.Exception)
        {

            Console.WriteLine("Error saving file");
        }

    }

    public static void delete(string filename)
    {
        // File.exists();
        /*
        *...
        */
    }
}