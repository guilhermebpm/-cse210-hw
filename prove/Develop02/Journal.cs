using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string file)
    {
    if (!file.EndsWith(".csv"))
    {
        file += ".csv";
    }

    string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "journals");
    Directory.CreateDirectory(directoryPath);
    string filePath = Path.Combine(directoryPath, file);

    using (StreamWriter writer = new StreamWriter(filePath))
    {
        writer.WriteLine("Date,Prompt,Entry");

        foreach (var entry in _entries)
        {
            writer.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{entry._entryText}\"");
        }
    }
    Console.WriteLine("Journal saved successfully as CSV.");
    }


    public void LoadFromFile(string file)
    {
        string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "journals");
        string filePath = Path.Combine(directoryPath, file);

        if (File.Exists(filePath))
        {
            _entries.Clear(); // Limpa as entradas atuais antes de carregar as novas
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    var entry = new Entry(parts[1], parts[2])
                    {
                        _date = parts[0] // Define diretamente a data
                    };
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found: " + filePath);
        }
    }
}
