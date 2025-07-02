// EternalGoal.cs

public class EternalGoal : Goal
{
    protected int _numberOfCompletions;
    public EternalGoal(string name, string description, int points, bool status, int completions) : base(name, description, points, false)
    {
        _goalType = "EternalGoal";
        _numberOfCompletions = completions;
    }
    public EternalGoal()
    {
        _goalType = "EternalGoal";
        _numberOfCompletions = 0;
    }
    public override void RunGoal()
    {
        Console.WriteLine($"Eternal Goal: {_name}");
        Console.WriteLine($"{_description}");
    }
    public override int RecordEvent()
    {
        _numberOfCompletions++;
        Console.WriteLine($"Nice! You've done {_name} {_numberOfCompletions} time(s)! You earned {_numberofPoints} points!");
        return _numberofPoints;
    }
    public override string ToString()
    {
        return $"{_goalType}|{_name}|{_description}|{_numberofPoints}|{_status}|{_numberOfCompletions}";
    }
    public override string ListGoal()
    {
        return $"[:)] {_name} ({_description}) -- Completed {_numberOfCompletions} times";
    }
}