using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    // substitute words with underscores
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string newWord = new string('_', _word.Length);
            return newWord;
        }
        return _word;
        
    }
}

