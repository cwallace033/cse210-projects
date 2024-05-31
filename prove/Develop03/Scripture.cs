


using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public void Display()
    {
        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", _words.Select(word => word.ToString())));
        Console.WriteLine();
    }

    public void EraseWords()
    {
        Random rand = new Random();
        for (int i = 0; i < 3; i++)
        {
            int randomIndex = rand.Next(_words.Count);
            _words[randomIndex].Erased();
        }
    }

    public bool AllWordsErased()
    {
        return _words.All(word => word.IsErased());
    }

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

}