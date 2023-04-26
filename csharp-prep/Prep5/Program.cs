using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squareNum = SquareNumber(number);
        DisplayResult(name, squareNum);
    }
  
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        } 

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int userNum = int.Parse(Console.ReadLine());

            return userNum;
        }

        static int SquareNumber(int number)
        {
            int numSquared = number * number;
            return numSquared;
        }

        static void DisplayResult(string userName, int numSquared)
        {
            Console.WriteLine($"{userName}, your favorite number squared is {numSquared}");
        }

}