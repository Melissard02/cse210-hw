// SimpleGoal.cs
using System;
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points, false)
    {
        _goalType = "SimpleGoal";
    }

    public SimpleGoal()
    {
        _goalType = "SimpleGoal";
    }

    public override void RunGoal()
    {
        Console.WriteLine($"Simple Goal: {_name}");
        Console.WriteLine($"{_description}");
    }

    public override int RecordEvent()
    {
        if (!_status)
        {
            Console.WriteLine($"Congrats! You completed the goal: {_name} and earned {_numberofPoints} points");
            return MarkComplete();
        }
        else
        {
            Console.WriteLine("You already completed this goal! Let's make a new goal!");
            return 0;
        }
    }

}