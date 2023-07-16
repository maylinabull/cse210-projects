using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running(new DateTime(2023, 7, 13), 30, 3);
        activities.Add(run1);
        Cycling cycle1 = new Cycling(new DateTime(2023, 7, 14), 15, 20);
        activities.Add(cycle1);
        Swimming swim1 = new Swimming(new DateTime(2023, 7, 15), 5, 20);
        activities.Add(swim1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}