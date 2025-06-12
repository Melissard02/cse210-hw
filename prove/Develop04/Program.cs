// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool running = true;

        while (running)
        {
            int choice = menu.DisplayMenu();
            if (choice == 1)
            {
                var activity = new Breathing("Breathing", "Guided Breathing.", 0);
                activity.RunActivity();
            }
            else if (choice == 2)
            {
                var activity = new Listing("Listing", "Write out your answers.", 0);
                activity.RunActivity();
            }
            else if (choice == 3)
            {
                var activity = new Reflection("Reflection", "Think about these questions.", 0);
                activity.RunActivity();
            }
            else if (choice == 4)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Enter a correct value");
            }
        }
    }
}