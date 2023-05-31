using System;

class Program
{
    static void Main(string[] args)
    {
     // if there are no more words to hide end program

     // testing methods
     // Word word = new Word("Book");

     // word.Display();
     // word.IsHidden(); 
     // word.Display();

     Console.Write("Would you like to memorize 1 or 2 scriptures? ");
     string scriptureNumber = Console.ReadLine();
     Scripture s = new Scripture("And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.");
     Scripture scr = new Scripture("And by the power of the Holy Ghost ye may know the truth of all things.");
     Console.Clear();

     bool end = false;
     while (end == false)
     { 
          Console.Clear();
          if (scriptureNumber == "1")
          {
               Reference r = new Reference();
               Console.WriteLine(r.GetReference());
               s.ShowScripture();
          }
          else if (scriptureNumber == "2")
          {
               Reference r = new Reference(scr);
               Console.WriteLine(r.GetReference());
               s.ShowScripture();
               scr.ShowScripture();
          }

          Console.Write("Press enter to continue or type 'quit' to finish: ");
          string userChoice = "";
          userChoice = Console.ReadLine();

          // if user presses enter hide words 
          if (userChoice == "" && scriptureNumber == "1")
          {
               s.HideWords();

          }
          else if (userChoice == "" && scriptureNumber == "2")
          {
               s.HideWords();
               scr.HideWords();
          }
          // no more words to hide end program
          // else if (IsCompletelyHidden...)
          // {
          //      end = true;
          //      break;
          // }
          //else if quit end program 
          else if (userChoice == "quit")
          {
               end = true;
               break;
          }
          else 
          {
               Console.WriteLine("Not a valid choice. Please press enter or type 'quit' to end the program");
               end = false;
               break;
          }
     }

    }
}