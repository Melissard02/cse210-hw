// Scripure.cs
using System;

class Scripture
{
    private List<Word> _words;

    private Reference _reference;

    private string _fullText;

    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new Reference(name, chapter, verse);
        _words = ConvertToWords(text);
        _fullText = text;
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(name, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
        _fullText = text;
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
        _fullText = text;
    }

    public bool HideSomeWords()
    {
        List<Word> unhiddenWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                unhiddenWords.Add(word);
            }
        }

        if (unhiddenWords.Count == 0)
        {
            return true;
        }


        Random rand = new Random();
        int wordsToHide = Math.Min(3, unhiddenWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(unhiddenWords.Count);
            unhiddenWords[index].SetIsHidden(true);
            unhiddenWords.RemoveAt(index);
        }

        return NumberOfHiddenWords() == _words.Count;
    }

    public void ShowScripture()
    {
        _reference.ShowReference();
        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
        Console.WriteLine();
    }

    public string GetReference()
    {
        return _reference.GetReference();
    }

    public string GetFullText()
    {
        return _fullText;
    }

    public Reference GetReferenceObject()
    {
        return _reference;
    }


    private int NumberOfHiddenWords()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> words = new List<Word>();
        string[] splitWords = text.Split(" ");

        foreach (string word in splitWords)
        {
            words.Add(new Word(word));
        }

        return words;
    }
}