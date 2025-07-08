//Menu.cs
using System;
using System.Threading;

public class Menu
{
    private Character _character;

    public void ShowMain()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== RPG BATTLE SIM ===");

            if (_character != null)
            {
                Console.WriteLine($"Character: {_character.GetName()}");
                Console.WriteLine($"Level: {_character.GetLevel()}");
            }
            else
            {
                Console.WriteLine("No character selected.");
            }

            Console.WriteLine();
            Console.WriteLine("1. Create Character");
            Console.WriteLine("2. Fight");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load Character");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateCharacter();
                    break;
                case "2":
                    if (_character != null)
                    {
                        Event battle = new Event();
                        battle.StartBattle(_character);
                    }
                    else
                    {
                        Console.WriteLine("Please create a character first.");
                    }
                    Pause();
                    break;
                case "3":
                    // TODO: implement Save
                    Console.WriteLine("Saving is not implemented yet.");
                    Pause();
                    break;
                case "4":
                    // TODO: implement Load
                    Console.WriteLine("Loading is not implemented yet.");
                    Pause();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Pick a number between 1 and 5");
                    Pause();
                    break;
            }
        }
    }

    private void CreateCharacter()
    {
        Console.Clear();
        Console.WriteLine("Select Character Type:");
        Console.WriteLine("1. Wizard");
        Console.WriteLine("2. Archer");
        Console.WriteLine("3. Warrior");
        Console.WriteLine("4. Rogue");
        Console.Write("> ");
        string input = Console.ReadLine();

        Console.Write("Name your character: ");
        string name = Console.ReadLine();

        // You can change these later to let the user customize them
        int health = 100;
        int attack = 10;
        int defense = 5;
        string weapon = "Basic Sword";
        int exp = 0;

        switch (input)
        {
            case "1":
                _character = new Wizard(name, weapon, health, attack, defense, exp);
                break;
            case "2":
                _character = new Archer(name, weapon, health, attack, defense, exp);
                break;
            case "3":
                _character = new Warrior(name, weapon, health, attack, defense, exp);
                break;
            case "4":
                _character = new Rogue(name, weapon, health, attack, defense, exp);
                break;
            default:
                Console.WriteLine("Select a number 1 through 4");
                Pause();
                return;
        }

        Console.WriteLine($"Welcome, {name} the {_character.GetType().Name}!");
        Pause();
    }

    private void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
