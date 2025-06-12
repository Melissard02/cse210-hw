//Listing.cs

class Listing : BaseActivity
{
    private List<UsedString> _prompts;

    public Listing(string name, string description, int seconds) : base(name, description, seconds){}

    public void RunActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();


        SetPrompts();
        ResetPrompts();
        

        int count = 0;
        ObtainDuration();
        StartTime();
        Console.WriteLine(GetPromptString(_prompts));


        while (!HasTimerExpired())
        {
            Console.Write("List item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items. Awesome!");
        DisplayEnding();
    }


    private void SetPrompts()
    {
        _prompts = new List<UsedString>()
        {
            new UsedString("Who are people that you appreciate?", false),
            new UsedString("What are your personal strengths?", false),
            new UsedString("What are you grateful for today?", false),
            new UsedString("List some acts of service you've done recently.", false),
            new UsedString("What made you smile today?", false)
        };
    }

    private void ResetPrompts()
    {
        foreach (UsedString prompt in _prompts)
        {
            prompt.SetBeenUsed(false);
        }
    }

}