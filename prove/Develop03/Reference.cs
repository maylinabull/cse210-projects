using System;


public class Reference 
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    // constructor for one scripture
    public Reference()
    {
        _book = "Moroni";
        _chapter = "10";
        _verse = "4";

    }

    // constructor for more than one scripture in reference 
    public Reference(Scripture anotherVerse)
    {
        _book = "Moroni";
        _chapter = "10";
        _verse = "4";
        _endVerse = "5";
    }

    public string GetReference() 
    {
        if (_endVerse != "")
        {
            string reference = ($"{_book} {_chapter}:{_verse}-{_endVerse}");
            return reference;
        }
        else
        {
            string reference = ($"{_book} {_chapter}:{_verse}");
            return reference;
        }
    }
}