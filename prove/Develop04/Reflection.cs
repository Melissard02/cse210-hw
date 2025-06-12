//Reflection.cs

class Reflection : BaseActivity
{
    private List<UsedString> _prompts;

    private List<UsedString> _questions;

    public Reflection(string name, string description, int seconds) : base(name, description, seconds) { }

    public void RunActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();

        SetPromptsAndQuestions();
        ResetPromptsAndQuestions();

        ObtainDuration();
        StartTime();

        Console.WriteLine(GetPromptString(_prompts));
        DisplaySpinner(3);

        while (!HasTimerExpired())
        {
            Console.WriteLine(GetPromptString(_questions));
            DisplaySpinner(5);
        }

        DisplayEnding();
    }

    private void SetPromptsAndQuestions()
    {
        _prompts = new List<UsedString>()
        {
            new UsedString("Think of a time when you felt peace today.", false),
            new UsedString("Recall a moment you felt close to God recently.", false),
            new UsedString("Reflect on a challenge you overcame with faith.", false)
        };

        _questions = new List<UsedString>()
        {
            new UsedString("Why do you think that moment stood out?", false),
            new UsedString("What did you learn about yourself?", false),
            new UsedString("How did you see God's hand in that experience?", false),
            new UsedString("What would you do differently next time?", false),
            new UsedString("How can you apply this reflection going forward?", false)
        };
    }
    
    private void ResetPromptsAndQuestions()
    {
        foreach (UsedString prompt in _prompts)
        {
            prompt.SetBeenUsed(false);
        }

        foreach (UsedString question in _questions)
        {
            question.SetBeenUsed(false);
        }
    }

}