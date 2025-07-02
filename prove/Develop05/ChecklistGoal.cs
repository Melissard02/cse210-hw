//ChecklistGoal.cs
using System;
public class ChecklistGoal : Goal
{
    protected int _numberOfCompletions;
    protected int _maxCompletions;
    protected int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, bool status, int completions, int max, int bonus) : base(name, description, points, false)
    {
        _goalType = "ChecklistGoal";
        _maxCompletions = max;
        _bonusPoints = bonus;
        _numberOfCompletions = completions;
    }
    public ChecklistGoal()
    {
        _goalType = "ChecklistGoal";
        _maxCompletions = 0;
        _bonusPoints = 0;
        _numberOfCompletions = 0;
    }
    public override void RunGoal()
    {
        Console.WriteLine($"Checklist Goal: {_name}");
        Console.WriteLine($"{_description}");
    }
    public override int RecordEvent()
    {
        _numberOfCompletions++;
        int totalPoints = _numberofPoints;
        if (_numberOfCompletions >= _maxCompletions)
        {
            if (!_status)
            {
                _status = true;
                totalPoints += _bonusPoints;
                Console.WriteLine($"WOO! You finished the entire checklist and earned a BONUS of {_bonusPoints} points!");
            }
        }
        Console.WriteLine($"Nice! You've completed {_name} {_numberOfCompletions}/{_maxCompletions} time(s). You earned {_numberofPoints} points!");
        return totalPoints;
    }
    public override string ToString()
    {
        return $"{_goalType}|{_name}|{_description}|{_numberofPoints}|{_status}|{_numberOfCompletions}|{_maxCompletions}|{_bonusPoints}";
    }
    public override string ListGoal()
    {
        string checkbox = _status ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description}) -- Completed {_numberOfCompletions}/{_maxCompletions}";
    }
}