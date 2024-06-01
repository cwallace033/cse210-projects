


using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rand;


    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            Console.Write(word + " ");
        }
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
        foreach (Word word in _words)
        {
            if (!word.IsErased())
            {
                return false;
            }
            
        }
        return true;
    }

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
        _rand = new Random();
    }

}