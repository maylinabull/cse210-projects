using System;

public class Scripture 
{
    private Reference _reference;

    List<Word> Words = new List<Word>();

    // private bool completelyHidden = false;
    
    public Scripture(string wholeScripture)
    {
        Reference reference = new Reference();
        _reference = reference;

        string[] bunchOfWords = wholeScripture.Split(" ");
        
        foreach (string singleWord in bunchOfWords){
            Word word = new Word(singleWord);
            Words.Add(word);
        }
    }
    // purpose is to hide the words one at a time and replace with underscores
    public void HideWords(){

        // Step 1: Select a random word from the word list.
        Random randomWord = new Random();
        Word word = Words[randomWord.Next(0, Words.Count)];

        // Step 2: validate that the word we selected is not already hidden.
        while (word._hiddenWord == true)
        {
            word = Words[randomWord.Next(0, Words.Count)];
        }

        // Step 3: After we have selected a random word which we have verified
        // is not already a hidden word, hide the word. 
        word.IsHidden();
    }

    public void ShowScripture(){
        // loop through your list of 'Words' and call the display function on them
        foreach (Word scriptureWord in Words)
        {
            scriptureWord.Display();

        }
        Console.WriteLine();
        Console.WriteLine();

    }

    //  public void IsCompletelyHidden() 
    //  {
    //     completelyHidden = true;
    //  }

    // public List GetRenderedText()
    // {
    //     return Words;
    // }



}