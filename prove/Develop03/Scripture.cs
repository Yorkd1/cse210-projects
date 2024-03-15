using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // interate through scripture and add words to a list
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] actualText = text.Split(" ");
        foreach(string i in actualText)
        {
            Word word = new Word(i);
            _words.Add(word);
        }
    }

    // create an algorithm that selects words from list 
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        foreach (Word word in _words.FindAll(word => !word.IsHidden()).OrderBy(w => random.Next()).Take(numberToHide))
        {
            word.Hide();
        }
    }

    // display scripture as it should appear
    public string GetDisplayText()
    {
        List<string> parts = new List<string>();

        foreach (Word word in _words)
        {
            string part = word.GetDisplayText();
            parts.Add(part);
        }

        string passage = String.Join(' ', parts);

        return passage;
        
    }

    // checks to see if words are underscores through the IsHidden method
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}