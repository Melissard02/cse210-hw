// Reference.cs
using System;

class Reference
{
    private string _bookname;

    private int _chapter;

    private int[] _verse;


    public Reference(string name, int chapter, int verse)
    {
        _bookname = name;
        _chapter = chapter;
        _verse = new int[] { verse };
    }

    public Reference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookname = name;
        _chapter = chapter;
        _verse = new int[] { startVerse, endVerse };
    }

    public void ShowReference()
    {
        Console.WriteLine(GetReferenceString());
    }

    public string GetReference()
    {
        return GetReferenceString();
    }

    private string GetReferenceString()
    {
        if (_verse.Length == 1)
        {
            return $"{_bookname} {_chapter}: {_verse[0]}";
        }
        else
        {
            return $"{_bookname} {_chapter}:{_verse[0]}-{_verse[1]}";
        }
    }
}