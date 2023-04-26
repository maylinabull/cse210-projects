using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int list_number = -1;
        while (list_number != 0) 
        {
            Console.Write("Enter number: ");
            list_number = int.Parse(Console.ReadLine());

            // add numbers to list
            if (list_number != 0)
            {
                numbers.Add(list_number);
            }

        }

        // calculate the sum of the list numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }    
        Console.WriteLine($"The sum is: {sum}");

        // calculate the average of the list numbers
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // find the max number in the list
        int max  = numbers[0];
        foreach (int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}