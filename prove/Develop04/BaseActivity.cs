//Base.cs

class BaseActivity
{
    private string _name;

    private string _description;

    private int _duration;

    private DateTime _endTime;


    public BaseActivity(string name, string description, int seconds)
    {
        _name = name;
        _description = description;
        _duration = seconds;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }


    public void DisplayEnding()
    {
        Console.WriteLine("Good Job");
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        DisplaySpinner(5);
    }


    public void RunCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }


    public void DisplaySpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            i++;
        }
    }


    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }


    public void ObtainDuration()
    {
        while (true)
        {
            Console.Write("Enter duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out _duration) && _duration > 0)
            {
                break;
            }
            Console.WriteLine("Please enter a valid positive number.");
        }
    }


    public string GetPromptString(List<UsedString> list)
    {
        Random rand = new Random();
        List<UsedString> unused = list.Where(item => !item.GetBeenUsed()).ToList();

        if (unused.Count == 0)
        {
            foreach (var item in list)
            {
                item.SetBeenUsed(false);
            }
            unused = new List<UsedString>(list);
        }

        int index = rand.Next(unused.Count);
        UsedString chosen = unused[index];
        chosen.SetBeenUsed(true);
        return chosen.GetPrompt();
    }

}

