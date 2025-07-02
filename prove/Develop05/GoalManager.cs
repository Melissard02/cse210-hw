//GoalManager.cs
using System.IO;
using System;
using System.Collections.Generic;
public class GoalManager
{
    public List<Goal> _goals;
    public string _filename;
    public int _totalScore;
    private int _level;
    private double _levelScore;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
        _level = 1;
        _levelScore = 100;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _totalScore = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            Goal goal = Goal.Deserialize(lines[i]);
            _goals.Add(goal);
        }
    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }
    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ListGoal()}");
        }
    }
    public int GetScore()
    {
        return _totalScore;
    }
    public int GetLevel()
    {
        return _level;
    }
    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int earned = _goals[goalIndex].RecordEvent();
            _totalScore += earned;
            Console.WriteLine($"You earned {earned} points. Total points: {_totalScore}");
            while (_totalScore > _levelScore)
            {
                _level++;
                _levelScore *= 1.5;
            }
            Console.WriteLine($"WOW! You leveled up! You are now level {_level}. Awesome Job :]");
        }
        else
        {
            Console.WriteLine("Invalid goal number");
        }
    }
}