using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // ---------- Fields ----------
    private Reference _reference;
    private List<Word> _words;
    private Random _random;


    // ---------- Constructor ----------
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();

        _words = new List<Word>();

        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }


    // ---------- Methods ----------
    public string GetDisplayText()
    {
        string referenceText = _reference.GetReferenceText();

        List<string> wordDisplays = new List<string>();
        foreach (Word word in _words)
        {
            wordDisplays.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", wordDisplays);

        return $"{referenceText}\n{scriptureText}";
    }

    public void HideRandomWords(int numberToHide = 3)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }

        return true;
    }
}
