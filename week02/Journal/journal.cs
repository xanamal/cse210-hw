using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("-------------------------");
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add(entry.ToFileString());
        }

        File.WriteAllText(filename, string.Join("~~ENTRY~~", lines));
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string content = File.ReadAllText(filename);
        string[] savedEntries = content.Split("~~ENTRY~~");

        foreach (string savedEntry in savedEntries)
        {
            if (savedEntry.Trim() != "")
            {
                _entries.Add(Entry.FromFileString(savedEntry));
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}