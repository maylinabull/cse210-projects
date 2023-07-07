using System;

class Video
{
    private string _title;
    private string _author; 
    private int _length;
    private List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }

    public int GetNumComments()
    {
        return _comments.Count();
    }
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comments(name, text));
    }
    // public void Display(string name, string text)
    // {
    //     foreach (Comments comment in _comments)
    //     {
    //        Console.WriteLine(name, text); 
    //     }
    // }
}