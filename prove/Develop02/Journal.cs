using System;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.IO.Enumeration;
using System.Linq.Expressions;
using System.Xml;

public class Entry
{
    public DateTime _date { get; set; }
    public string _prompt { get; set; }
    public string _userInput { get; set; }

}
public class Journal
{
    // List of entries
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string userInput)
    {
        Entry _entry = new Entry
        {
            _date = DateTime.Now,
            _prompt = prompt,
            _userInput = userInput,
        };

        _entries.Add(_entry);

    }

    public void DisplayEntryies()
    {
        Console.WriteLine("Entries");
        foreach (var _entry in _entries)
            Console.WriteLine($"date{_entry._date},promt{_entry._prompt},input{_entry._userInput}");

    }
        public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))

        foreach (Entry _entry in _entries)
        {
            outputFile.WriteLine($"{_entry._date}, {_entry._prompt},{_entry._userInput}");
        }

    }

    public void Load(string filename){
    _entries.Clear();
    try
    {
    
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split(",");

            if (parts.Length == 3)
            {
                entry._date = DateTime.Parse(parts[0]);
                entry._prompt = parts[1];
                entry._userInput = parts[2];
                _entries.Add(entry);

                Console.WriteLine($"Date: {entry._date}\nPromt: {entry._prompt}\nResponse: {entry._userInput}");

            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
    catch (FileNotFoundException)
    {
       Console.WriteLine("The file you entered was not found");
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred:" + ex.Message);
    }
}
};