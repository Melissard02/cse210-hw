//Beathing.cs

class Breathing : BaseActivity
{
    public Breathing(string name, string description, int seconds) : base(name, description, seconds){}

    public void RunActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();

        ObtainDuration();
        Console.WriteLine("Get ready to start the activity in...");
        RunCountDown(5);

        StartTime();

        while (!HasTimerExpired())
        {
            Console.WriteLine("\nBreathe in...");
            RunCountDown(4);
            Console.WriteLine("\nBreathe out...");
            RunCountDown(4);
        }

        DisplayEnding();

    }
}