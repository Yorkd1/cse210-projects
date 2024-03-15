using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // if reference has only one verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    // if reference has more than one verse
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        // Determine which reference template should be used
        string text = "";
        if (_endVerse == 0)
        {
            text = $"{_book} {_chapter}:{_verse}";
        }
        else 
        {
            text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        return text;
    }
}