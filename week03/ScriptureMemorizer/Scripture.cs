using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
            .Select(word => new Word(word))
            .ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var word = visibleWords[_random.Next(visibleWords.Count)];
            word.Hide();
            visibleWords.Remove(word); // prevents re-hiding same word
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public override string ToString()
    {
        return _reference.ToString() + " " + string.Join(" ", _words);
    }
}
