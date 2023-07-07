using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> _videos = new List<Video>();

       Video video1 = new Video("How to program in C#", "Shannon Smith", 120);
       video1.AddComment("Bobby Brown", "Thank you for the informative video! I now have a better understanding of the basics of C#.");
       video1.AddComment("Paige Potter", "I'm used to using Python. C# is so different!");
       video1.AddComment("Gina George", "I don't get polymorphism. Could someone explain this in simpler terms for me?");
       _videos.Add(video1);
       Video video2 = new Video("The Future of AI", "Albert Einstein", 200);
       video2.AddComment("Jen Jensen", "Technology has come a long way. Excited for the future ... except for the part where a lot of jobs will be taken by AI.");  
       video2.AddComment("Candace Christensen", "Too many of these videos focus on the negatives of AI. Imagine what it could do in the healthcare industry!");
       video2.AddComment("Lincoln Lopez", "What an amazing perspective. The possibilities seem endless.");
       _videos.Add(video2);
       Video video3 = new Video("Barbie v. Oppenheimer", "Henry Ford", 100);
       video3.AddComment("Kent Kelly", "I don't get the hype around either movie. Won't be seeing either");
       video3.AddComment("Lauren Lemon", "Easy. Barbie in the morning, Oppenheimer in the evening.");
       video3.AddComment("David Davidson", "I'm going to watch Spiderverse for the 10th time instead.");
       video3.AddComment("Alex Andersen", "Ryan Gosling is too old to play Ken . . .");
       _videos.Add(video3); 

       foreach (Video video in _videos)
       {
        Console.WriteLine($"Title: {video.GetTitle()}");
        Console.WriteLine($"Author: {video.GetAuthor()}");
        Console.WriteLine($"Length in seconds: {video.GetLength()}");
        Console.WriteLine($"Number of comments: {video.GetNumComments()}");
       }
    //    foreach comment display the name and text
    


    }
}