using System;


public class Activities
{
protected string _title;
protected string _description;
protected int _time; 

public Activities()
{

}

public Activities(string title, int time)
{
    _title = title;
    _time = time;
}

public Activities(string title, string description, int time)
{
    _title = title;
    _description = description;
    _time = time;

}
public void DisplayStartMessage()
{
    Console.WriteLine($"Welcome to the {_title} ");
    Console.WriteLine(_description);
}

public void SetTime()
{
    Console.Write("How long, in seconds, would you like for your session? ");
    int userTime = int.Parse(Console.ReadLine());
    _time = userTime;
    Console.WriteLine("Get ready . . .");
    PauseSpinner();
}

public int GetTime()
{
    return _time;
}

public void DisplayEndingMessage()
{
    Console.WriteLine();
    Console.Write("Well done!!");
    PauseSpinner();
    Console.WriteLine();
    Console.Write($"You have completed another {_time} seconds of the {_title}.");
    PauseSpinner();
}

public void PauseSpinner()
{
    List <string> spinnerComponents = new List<string>();
    spinnerComponents.Add("|");
    spinnerComponents.Add("/");
    spinnerComponents.Add("-");
    spinnerComponents.Add("\\");
    spinnerComponents.Add("|");
    spinnerComponents.Add("/");
    spinnerComponents.Add("-");
    spinnerComponents.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(10);

       int i = 0;

    while (DateTime.Now < endTime)
    {
        string s =  spinnerComponents[i];
        Console.Write(s);
        Thread.Sleep(500);
        Console.Write("\b \b");

        i++;

        if (i >= spinnerComponents.Count)
        {
            i = 0;
        }
    }
}

public void PauseTimer(int counter)
{
    for (int i = counter; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}

public virtual void RunActivity()
{

}

public void RateActivity()
{
    Console.Clear();
    Console.WriteLine("How would you rate this activity from 1-10?");
    int rating = int.Parse(Console.ReadLine());

    if (rating >= 7 && rating <= 10)
    {
        Console.WriteLine("Thank You!");
    }
    else if (rating <= 5 && rating > 0)
    {
        Console.WriteLine("Sorry you feel that way. We will try to improve the activity.");
    }
}

}