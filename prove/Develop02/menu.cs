using System;

class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Save Journal to a File");
        Console.WriteLine("4. Load Journal from a File");
        Console.WriteLine("5. Exit");

        string userChoice = Console.ReadLine();
        int choice = int.Parse(userChoice);

        return choice;

    }


    public void CreateMenu(Journal journal)
    {
        int response = 0;
        while (response != 5)
        {
            response = DisplayMenu();
            switch (response)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Enter a filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveJournal(saveFile);
                    break;
                case 4:
                    Console.WriteLine("Enter a file to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadJournal(loadFile);
                    break;
                case 5:
                    break;
            }
        }
    }
}