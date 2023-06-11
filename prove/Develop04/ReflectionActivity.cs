using System;

public class ReflectionActivity : Activities
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else. ",
        "Think of a time when you did something really difficult. ",
        "Think of a time when you helped someone in need. ",
        "Think of a time when you did something truly selfless. ",
        "Think of a time when you went through big changes. ",
        "Think of a time when you did something you were proud of. "
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you? ", 
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    public ReflectionActivity(string title, string description, int time) : base(title, description, time)
    {
        _title = title;
        _description = description;
        _time = time;
    }

    public string GetPrompt()
    {
        Random randomPrompt = new Random();
        string prompt = _prompts[randomPrompt.Next(1,6)];
        return prompt;
    }

    public string GetQuestions()
    {
        Random randomPrompt = new Random();
        string question = _questions[randomPrompt.Next(1,9)];
        return question;
    }


    public override void RunActivity()
    {   
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--------{GetPrompt()}--------");
        
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string enter = Console.ReadLine();

        if (enter.Length == 0)
        {
        Console.WriteLine("Now ponder each of the following questions as they are related to this experience.");

        Console.WriteLine("You may begin in: ");
        PauseTimer(5);
        Console.Clear();
        }

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        while (DateTime.Now < futureTime)
        {
            Console.Write($"> {GetQuestions()}");
            PauseSpinner();
            Console.WriteLine();

        }

    }
}