using System;

public class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
    }

    public void Display()
    {


        if (_hiddenWord == false)
        {
            Console.Write(_word + " ");
        }
        else{
            foreach (char letter in _word)
            { 
                if (letter != ' ') // if last character in word, print underscore and space "_ " How would I do that? ??letter == _word[_word.Count - 1]??
                {
                Console.Write("_");
                }
            }
        }
    }
    public bool _hiddenWord = false; 
    public void IsHidden()
    {
        _hiddenWord = true;
    }

    // public string GetRenderedText()
    // {
    //     //return
    // }

}