using System;

public class PromptGenerator
{
    // journal prompt list 
    static List<string> _prompts = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What areas of my life could I have improved today?",
        "Did I meet all my goals for today? If not, why?",
        "What was something that made you smile today?",
        "What are you grateful for today?",
        "What is something you learned today?",
        "What did you eat today?",
        "What is the most exciting thing that happened today?",
        "What challenges did you face today?"
    };

    // constructor
    public PromptGenerator()
    {
        
    }

    // generate prompt
    public string RandomPrompt() 
    {
        Random randomPrompt = new Random();
        string prompt = _prompts[randomPrompt.Next(1,12)];
        return prompt;
    }

    // display a random prompt
    public void DisplayPrompt()
    {
        Console.WriteLine(RandomPrompt());
    }

}