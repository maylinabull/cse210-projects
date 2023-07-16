using System;

class Program
{
    static void Main(string[] args)
    {
       // create events
       // lecture 
       Address address1 = new Address("777 Seven St.", "New Town", "MO", "USA");
       Lecture lecture1 = new Lecture("Robert Roberts", 25, "C# 101", "Learn the basics of C#", new DateTime(2023, 7, 13), new TimeSpan(12, 0, 0), address1, "Lecture");

       // reception
       Address address2 = new Address("222 Two St.", "Old Town", "CA", "USA");
       Reception reception1 = new Reception("random@gmail.com", "Career Fair", "Explore possible careers or internships", new DateTime(2023, 7, 14), new TimeSpan(4, 0, 0), address2, "Reception");

       // outdoor gathering 
       Address address3 = new Address("333 Three St.", "MidTown", "NY", "USA");
       OutdoorGathering outdoorGathering1 = new OutdoorGathering("Super sunny with a high of 100", "Summer Fair", "Carnival activities for all", new DateTime(2023, 7, 15), new TimeSpan(5, 0, 0), address3, "Outdoor Gathering");

       // marketing messages

       // lecture
       Console.WriteLine(lecture1.GetStandardDetails());
       Console.WriteLine();
       Console.WriteLine(lecture1.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(lecture1.GetShortDescription());
       Console.WriteLine();

       // reception 
       Console.WriteLine(reception1.GetStandardDetails());
       Console.WriteLine();
       Console.WriteLine(reception1.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(reception1.GetShortDescription());
       Console.WriteLine();

       // outdoor gathering 
       Console.WriteLine(outdoorGathering1.GetStandardDetails());
       Console.WriteLine();
       Console.WriteLine(outdoorGathering1.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(outdoorGathering1.GetShortDescription());
       Console.WriteLine();
       
        

    }
}