// Scripure.cs
using System;

class Scripture
{
    private List<Word> _words;

    private Reference _reference;

    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new Reference(name, chapter, verse);
        _words = ConvertToWords(text);
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(name, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
    }

    public bool HideSomeWords()
    {
        Random rand = new Random();
        int wordsToHide = 3;
        int count = 0;

        while (count < wordsToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].SetIsHidden(true);
                count++;
            }
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