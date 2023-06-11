using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";

        while (userChoice != "4")
        {
            // menu for users to choose an activity
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            if (userChoice == "1")
            {
                // start message 
                 Activities time = new Activities();
                 Activities startMessage = new Activities("Breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", time.GetTime());
                 startMessage.DisplayStartMessage();
                 time.SetTime();

                 // run breathing activity
                 BreathingActivity run = new BreathingActivity("Breathing activity", " ", time.GetTime());
                 run.RunActivity();

                 //end message 
                 Activities endMessage = new Activities("Breathing activity", time.GetTime());
                 endMessage.DisplayEndingMessage();

                 // rate activity
                 Activities rate = new Activities();
                 rate.RateActivity();
            }

            else if (userChoice == "2")
            {
                // reflection activity start message 
                Activities time = new Activities();
                Activities startMessage = new Activities("Reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", time.GetTime());
                startMessage.DisplayStartMessage();
                time.SetTime();
                Console.Clear();

                ReflectionActivity run = new ReflectionActivity("Reflection activity", " ", time.GetTime());
                run.RunActivity();

                // reflection activity end message
                Activities endMessage = new Activities("Reflection activity", time.GetTime());
                endMessage.DisplayEndingMessage();

                // rate activity
                 Activities rate = new Activities();
                 rate.RateActivity();
                
            }

            else if (userChoice == "3")
            {
                // listing activity start message
                Activities time = new Activities();
                Activities startMessage = new Activities("Listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", time.GetTime());
                startMessage.DisplayStartMessage();
                time.SetTime();
                Console.Clear();

                ListingActivity run = new ListingActivity("Listing activity", " ", time.GetTime());
                run.RunActivity();

                // listing activity end message 
                Activities endMessage = new Activities("Listing activity", time.GetTime());
                endMessage.DisplayEndingMessage();
                
                // rate activity
                 Activities rate = new Activities();
                 rate.RateActivity();
            }

            else if (userChoice == "4")
            {
                // quit
                Console.WriteLine("Bye!");
            }

            else 
            {
                Console.WriteLine("That wasn't a valid menu option");
            }
        }



    }




}