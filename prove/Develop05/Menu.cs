class Menu
{

    public int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Select an Goal Type");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Quit");

        Console.Write("> ");

        string userChoice = Console.ReadLine();

        if (int.TryParse(userChoice, out int choice))
        {
            if (choice >= 1 && choice <= 4)
            {
                return choice; // valid choice, exit loop
            }
        }

        Console.WriteLine("Oops! Please enter a number between 1 and 4.");
        Thread.Sleep(1500);

        return 0;
    }

}