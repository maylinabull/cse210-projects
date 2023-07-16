using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running run1 = new Running(new DateTime(2022, 11, 3), 30, 3);
        _activities.Add(run1);
        Cycling cycle1 = new Cycling(new DateTime(2022, 11, 3), 15, 20);
        _activities.Add(cycle1);
        Swimming swim1 = new Swimming(new DateTime(2022, 11, 3), 3, 20);
        _activities.Add(swim1);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}