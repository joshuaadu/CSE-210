using System.IO;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            // foreach (string line in File.ReadLines(filename))
            // {
            //     if (line == "")
            //     {
            //         continue;
            //     }
            //     string[] parts = line.Split('|');
            //     DateTime date = DateTime.Parse(parts[0]);
            //     string prompt = parts[1];
            //     string content = parts[2];
            //     Entry entry = new Entry(content, date, prompt);
            //     entries.Add(entry);
            // }
            string json = File.ReadAllText(filename);
            Entry[] entriesArray = JsonSerializer.Deserialize<Entry[]>(json);
            // entries = new List<Entry>(entriesArray);
            entries = entriesArray.ToList();
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
            // To pretty-print the JSON string, you can set the JsonSerializerOptions.WriteIndented to true. 
            // However, formatting the JSON might have a negative impact on performance.
            // var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(entries);
            File.WriteAllText(filename, json);
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