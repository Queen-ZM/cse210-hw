using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       List<Person> newPeople = ReadFromFile();
       foreach (Person p in newPeople)
       {
           Console.WriteLine(p._lastName);
       }
    }

    public static void SaveToFile(List<Person> people)
    {
       Console.WriteLine("This shows that the code is saving to file...");

        string filename = "people.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName}~~{p._lastName}~~{p._age}");
            }

        }
    }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from the file directly.....");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line); //
           //line will have something like this: Lonke~~Zilimbola~~8"
           string[] parts = line.Split("~~");

           //parts[0] - Lonke
           //parts[1] - zilimbola
           //parts[2] - 8

           Person newPerson = new Person();
           newPerson._firstName = parts[0];
           newPerson._lastName = parts[1];
           newPerson._age = int.Parse(parts[2]);

           people.Add(newPerson);
        }

        return people;
    }
}