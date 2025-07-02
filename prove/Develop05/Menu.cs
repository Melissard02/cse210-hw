// Menu.cs
using System;
using System.Threading;
using System.Collections.Generic;
public class Menu
{
    private GoalManager _manager;

    public Menu(GoalManager manager)
    {
        _manager = manager;
    }
    public void ShowMain()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine($"Score: {_manager.GetScore()}");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event (Complete a Goal)");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    _manager.DisplayGoals();
                    Pause();
                    break;
                case "3":
                    Console.Write("Filename to save: ");
                    string saveName = Console.ReadLine();
                    _manager.SaveGoals(saveName);
                    Console.WriteLine("Saved!");
                    Pause();
                    break;
                case "4":
                    Console.Write("Filename to load: ");
                    string loadName = Console.ReadLine();
                    _manager.LoadGoals(loadName);
                    Console.WriteLine("Loaded!");
                    Pause();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Pick a number between 1 and 6");
                    Pause();
                    break;
            }
        }
    }
    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("> ");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Select a number 1 through 3");
                Pause();
                break;
        }
    }
    private void CreateSimpleGoal()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());
        bool status = false;
        _manager.AddGoal(new SimpleGoal(name, desc, points, status));
        Console.WriteLine("Simple Goal added!");
        Pause();
    }
    private void CreateEternalGoal()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points per completion: ");
        int points = int.Parse(Console.ReadLine());
        bool status = false;
        Console.Write("Completions: ");
        int completions = int.Parse(Console.ReadLine());
        _manager.AddGoal(new EternalGoal(name, desc, points, status, completions));
        Console.WriteLine("Eternal Goal added!");
        Pause();
    }
    private void CreateChecklistGoal()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points per completion: ");
        int points = int.Parse(Console.ReadLine());
        if (!int.TryParse(Console.ReadLine(), out _))
        {
            Console.WriteLine("Invalid input, try again!");
            return;
        }

        Console.Write("Times needed to complete: ");
        int target = int.Parse(Console.ReadLine());
        if (!int.TryParse(Console.ReadLine(), out _))
        {
            Console.WriteLine("Invalid input, try again!");
            return;
        }

        Console.Write("Times completed: 0");
        int completions = 0;

        // Set the status automatically to false
        bool status = false;

        Console.Write("Bonus points for completing every goal: ");
        int bonus = int.Parse(Console.ReadLine());
        if (!int.TryParse(Console.ReadLine(), out _))
        {
            Console.WriteLine("Invalid input, try again!");
            return;
        }
        
        _manager.AddGoal(new ChecklistGoal(name, desc, points, status, completions, target, bonus));
        Console.WriteLine("Checklist Goal added!");
        Pause();
    }
    private void RecordEvent()
    {
        Console.Clear();
        _manager.DisplayGoals();
        Console.Write("Which goal number did you complete? ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            _manager.RecordEvent(choice - 1);
        }
        else
        {
            Console.WriteLine("Please input a correct number.");
        }
        Pause();
    }
    private void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
