using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Scripture
{
    private List<Word> words;

    public Scripture(string scripture)
    {
        words = scripture.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int indexToHide = random.Next(0, words.Count);
        words[indexToHide] = new Word("___"); // Replace word with underscores to hide it.
    }

    public override string ToString()
    {
        return string.Join(" ", words.Select(word => word.Value));
    }
}
