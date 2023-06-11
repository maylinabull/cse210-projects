using System;

public class BreathingActivity : Activities
{
    private string message1 = "Breathe in ... ";
    private string message2 = "Breathe out ... ";

    public BreathingActivity()
    {

    }
    
    public BreathingActivity(string title, string description, int time)
        : base(title, description, time)
    {
        _title = title;
        _description = description;
        _time = time;
    }

    public override void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        while (DateTime.Now < futureTime)
        {
            Console.Write(message1); 	
            PauseTimer(4);
            Console.Write(message2); 
            PauseTimer(6);
        }

    }

}