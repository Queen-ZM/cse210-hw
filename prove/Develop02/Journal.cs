using System;

public class Entry
{
    DateTime _date {get; set;}
    string _prompt {get; set;}
    string _userInput {get; set;}

}
public class Journal
{
    // List of entries
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string userInput)
    {
        Entry _entry = new Entry{
            _date = DateTime.Now, 
            _prompt = prompt,
            _userInput = userInput, 
        };

        _entries.Add(_entry);

    }

    public void Save()
    {
        string filename = "Questions.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
           string[] parts = line.Split(",");

        }

    }

    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

       foreach (string line in lines)
       {
          Console.WriteLine(line);

          string[] parts = line.Split(",");

       }
    }
}