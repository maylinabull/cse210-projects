using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();

        string userChoice = "";
        while (userChoice != "6")
        {
            // goal menu options
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu ");
            userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            // have user decide what kind of goal to create
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.WriteLine("What type of goal would you like to create? ");
            string type = Console.ReadLine();

            // simple goal type
            if (type == "1")
            {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simpGoal = new SimpleGoal("Simple Goal: ", name, description, points, false);
            _goals.Add(simpGoal);
            }
            // eternal goal type
            else if (type == "2")
            {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int points = int.Parse(Console.ReadLine());
            EternalGoal etGoal = new EternalGoal("Eternal Goal: ", name, description, points);
            _goals.Add(etGoal);
            }
            // checklist goal type
            else if (type == "3")
            {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
            int numTimes = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?  ");
            int bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal checkGoal = new ChecklistGoal("Checklist Goal: ", name, description, points, numTimes, bonusPoints);
            _goals.Add(checkGoal);
            }
        }
        //list
        else if (userChoice == "2")
        {
            Goal goals = new Goal();
            Console.WriteLine($"You currently have {goals.GetTotalPoints()} points");
            Console.WriteLine("The goals are: ");
            for (int count = 0; count < _goals.Count; count++){
            Console.WriteLine($"{count + 1}. {_goals[count].GetPrintFormat()}");
            }
        }
        //save
        else if (userChoice == "3")
        {
            
            // write to file 
            Console.WriteLine("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetSaveFormat());
                }
            }
        }
        //load 
        else if (userChoice == "4")
        {
            Goal goal = new Goal();
            Console.WriteLine($"You currently have {goal.GetTotalPoints()} points");
            Console.WriteLine("What is the filename for the goal file? ");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string _type =  parts[0];
                string _name = parts[1];
                string _description = parts[2];
                string _points = parts[3];
                string _status = parts[4];

                _goals.Add(goal);
            }            
        }
        //record
        else if (userChoice == "5")
        {
            Goal goals = new Goal();
            Console.WriteLine($"You currently have {goals.GetTotalPoints()} points");
            Console.WriteLine("Which goal did you accomplish?");
            int accompGoal = int.Parse(Console.ReadLine());
            goals.RecordEvent();
        
         }
        //quit
        else if (userChoice == "6")
        {
            Console.WriteLine("Bye!");
        }
        else 
        {
            Console.WriteLine("That wasn't a valid menu option");
        }
        }


    }
}