
class Comments
{
private string _name;
private string _text;

public Comments(string name, string text)
{
    _name = name;
    _text = text;
}
public Comments()
{
    
}

public string GetName()
{ 
    return _name;
}
public string GetText()
{
    return _text;
}
}