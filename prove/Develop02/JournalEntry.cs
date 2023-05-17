using System;

public class JournalEntry
{
        // member variables
        public string _prompt;
        public string _entry;
        public string _date;
        public string _dayRating;
        public JournalEntry() 
        {
            DateTime theCurrentTime = DateTime.Now;
           _date = theCurrentTime.ToShortDateString();
    
        }

        public void Display()
        {
            // display an entry 
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_prompt}");
            Console.WriteLine($"Entry: {_entry}");
            Console.WriteLine($"Day Rating: {_dayRating}");
        }

}