using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {

        _goals = new List<Goal>();
        _score = 0;

    }

    public void Start()
    {

        string option;

        do
        {

            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            option = Console.ReadLine();

            if (option == "1")
            {

                CreateGoal();

            }

            else if (option == "2")
            {

                ListGoalDetails();

            }

            else if (option == "3")
            {
                SaveGoals();
            }

            else if (option == "4")
            {
                LoadGoals();
            }

            else if (option == "5")
            {
                RecordEvent();
            }




        } while (option != "6");

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine();
    }
    public void CreateGoal()
    {
        string option;
        string goalName;
        string goalDescription;
        int goalPoints;
        int goalTarget;
        int goalBonus;



        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");

        option = Console.ReadLine();


        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        goalPoints = int.Parse(Console.ReadLine());


        if (option == "1")
        {

            Console.WriteLine();
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);

            _goals.Add(simpleGoal);


        }

        else if (option == "2")
        {

            Console.WriteLine();
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);

            _goals.Add(eternalGoal);

        }

        else if (option == "3")
        {


            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            goalTarget = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            goalBonus = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);

            _goals.Add(checklistGoal);

        }

    }
    public void RecordEvent()
    {
        int goalIndex;
        int points;

        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");

        goalIndex = int.Parse(Console.ReadLine());

        //This step avoids adding points to goals that have already been completed
        if (_goals[goalIndex - 1].IsComplete())
        {
            Console.WriteLine("You have already completed this goal.");

            Console.WriteLine();
        }
        else
        {

            _goals[goalIndex - 1].RecordEvent();

            points = _goals[goalIndex - 1].GetPoints();

            _score += points;

            Console.WriteLine($"You now have {_score} points.");

            Console.WriteLine();

        }
    }
    public void SaveGoals()
    {
        string fileName;
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //Save the score information in the first line of the file
            outputFile.WriteLine($"{_score}");

            //Iterate through the goals list and save each goal details in a line of the file
            for (int i = 0; i < _goals.Count; i++)
            {
                outputFile.WriteLine(_goals[i].GetStringRepresentation());
            }

        }

        Console.WriteLine();


    }
    public void LoadGoals()
    {
        //When load goals from a file the program will clear the goals list to avoid inconsistency
        _goals.Clear();

        string fileName;
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        //The first line of the file stores the score
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            if (parts[0] == "SimpleGoal")
            {
                parts = parts[1].Split(";");
                SimpleGoal simpleGoal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                _goals.Add(simpleGoal);

            }
            else if (parts[0] == "EternalGoal")
            {
                parts = parts[1].Split(";");
                EternalGoal eternalGoal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                _goals.Add(eternalGoal);

            }
            else if (parts[0] == "ChecklistGoal")
            {
                parts = parts[1].Split(";");
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                _goals.Add(checklistGoal);

            }

        }

    }


}


