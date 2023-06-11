using System;

public class ListingActivity : Activities
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes? ",
        "What are you grateful for today? ",
        "What are some happy memories you've had? "
    };

    public ListingActivity(string title, string description, int time)
        : base(title, description, time)
    {
        _title = title;
        _description = description;
        _time = time;
    }
    public string GetPrompt()
    {
        Random randomPrompt = new Random();
        string prompt = _prompts[randomPrompt.Next(1,7)];
        return prompt;
    }

    public override void RunActivity()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--------{GetPrompt()}--------");

        Console.Write("You may begin in: ");
        PauseTimer(5);
        Console.WriteLine();
        // Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        int i = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string enter = Console.ReadLine();
            i++;
        
        }
        Console.WriteLine($"You listed {i} items!");
    }

}