using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 101);
    
        int guess_num = 0;
        int count = 0;

        while (magic_num != guess_num )
        { 
        Console.Write("What is your guess? ");
        guess_num = int.Parse(Console.ReadLine());
        count += 1;

            if (magic_num > guess_num)
                {
                    Console.WriteLine("Higher");
                }
            else if (magic_num < guess_num)
                {
                    Console.WriteLine("Lower");
                }
            else 
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {count} tries");
                }
        }
        


    }
}
