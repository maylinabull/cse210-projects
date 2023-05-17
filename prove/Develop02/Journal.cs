using System;
using System.IO;

class Journal
{
    public List<JournalEntry> _journal = new List<JournalEntry>();

    public void AddToFile()
    {
       // write to file 
       string fileName = Console.ReadLine();

       using (StreamWriter outputFile = new StreamWriter(fileName))
       {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._date}|{journalEntry._prompt}|{journalEntry._entry}");
            }
       }
        
    }
    public void LoadFile()
    {
        // read from file

        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            JournalEntry journalEntry = new JournalEntry();

            journalEntry._date =  parts[0];
            journalEntry._prompt = parts[1];
            journalEntry._entry = parts[2];

            _journal.Add(journalEntry);

        }
    }

    public void Display()
    {
        // display entries
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
    }

}