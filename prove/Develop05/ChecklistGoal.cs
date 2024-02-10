using System;

public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;

        if (IsComplete())
        {
            //When a checklist goal is completed, shows a special message and adds bonus to the points
            Console.WriteLine($"YOU HAVE DONE IT!!!!");
            Console.WriteLine($"You have finally completed this goal for {_amountCompleted} times!");
            Console.WriteLine($"You are going to get the bonus of {_bonus} extra points!");
            _points += _bonus;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }

    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        string detailsString;

        if (IsComplete())
        {

            detailsString = $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            detailsString = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        return detailsString; ;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName};{_description};{_points};{_target};{_bonus};{_amountCompleted}";
    }

}




