using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = " ";

        PromptGenerator newJournalPrompt = new PromptGenerator();
        Journal journal = new Journal();

        while (userChoice != "5") 
        {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.WriteLine("What would you like to do?");
        userChoice = Console.ReadLine();
        Console.WriteLine();
        string userEntry;

            if (userChoice == "1")
            {
                JournalEntry newJournalEntry = new JournalEntry();
                //write
                string prompt = newJournalPrompt.RandomPrompt();
                newJournalEntry._prompt = prompt;
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                userEntry = Console.ReadLine();
                // journal.AddToFile();

                newJournalEntry._entry = userEntry;
                journal._journal.Add(newJournalEntry);
            }
            else if (userChoice == "2")
            {
                // display entries
                journal.Display();
            }
            else if (userChoice == "3")
            {
                //load
                Console.WriteLine("What is the file name? ");

                journal.LoadFile();

            }
            else if (userChoice == "4")
            {
                //save
                Console.WriteLine("What is the file name? ");
            
                journal.AddToFile();
            }
            else if (userChoice == "5")
            {
                //quit
                Console.WriteLine("Bye!");
            }
            else 
            {
                Console.WriteLine("That wasn't a valid menu option");
            }
        }  

    }
       
}