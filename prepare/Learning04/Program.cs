using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Maylina Bull", "Division");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Maylina Bull", "Division","7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());

    }
}