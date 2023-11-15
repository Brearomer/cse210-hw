using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

public class Journal
{
    public List<Entry> _entries = new();

    public void AddEntry()
    {
        Entry entry = new();
        entry.Write();
        _entries.Add(entry);
    }


    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
            entry.Display();
    }

    public void Save(string filename)
    {
        using (StreamWriter output = new(filename, true))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }


    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
    }


}