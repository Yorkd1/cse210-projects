using System;
using System.IO;
public class Journal
{
    // list of journal entries
    public List<Entry> _entries = new List<Entry>();

    // Create method to add entries to list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        
    }

    // create method to display all entries in current instance
    public void DisplayAll()
    {
        foreach(var i in _entries)
                {    
                    Console.WriteLine($"Date: {i._date} - Prompt: {i._promptText}\n{i._entryText}");
                }        
    }

    // create method to load entries from a file
    public void LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }

    // create method to save entries to a file 
    public void SaveToFile(string file)
    {
        
        using(TextWriter tw = new StreamWriter(file))
        {
            foreach(var i in _entries)
            tw.WriteLine($"Date: {i._date} - Prompt: {i._promptText}\n{i._entryText}");
        }
    }
}    