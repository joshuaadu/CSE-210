using System.IO;
using System;

class File
{


    static public void load(string filename, List<Entry> entries)
    {
        // File.exists();
        /*
        *...
        */
        try
        {

            Console.WriteLine("Load File");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


    public static void save(string filename, List<Entry> entries)
    {
        // File.exists();
        /*
        *...
        */
    }

    public static void delete(string filename)
    {
        // File.exists();
        /*
        *...
        */
    }
}