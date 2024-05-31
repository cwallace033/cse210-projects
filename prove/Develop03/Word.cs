

using System.Configuration.Assemblies;
using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isErased;


    public Word(string text)
    {
        _text = text;
        _isErased = false;
    }

    public void Erased()
    {
        _isErased = true;
    }

    public bool IsErased()
    {
        return _isErased;
    }

    public override string ToString()
    {
        return _isErased ? "____" : _text;
    }
    
    
}