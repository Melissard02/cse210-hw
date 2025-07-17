//Menu.cs
using System;
using System.Threading;
using System.IO;
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
                    Console.Write("Name your save file: ");
                    string saveName = Console.ReadLine();
                    SaveGame(saveName);
                    Console.WriteLine("Saved game!");
                    Pause();
                    break;
                case "4":
                    Console.Write("Name of Save File: ");
                    string loadName = Console.ReadLine();
                    LoadGame(loadName);
                    Console.WriteLine("Game Loaded!");
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
        Console.WriteLine("=== RPG BATTLE SIM ===");
        Console.WriteLine();
        Console.WriteLine("Select Character Type:");
        Console.WriteLine("1. Wizard");
        Console.WriteLine("2. Archer");
        Console.WriteLine("3. Warrior");
        Console.WriteLine("4. Rogue");
        Console.Write("> ");
        string input = Console.ReadLine();

        Console.WriteLine();
        Console.Write("Name your character: ");
        string name = Console.ReadLine();

        switch (input)
        {
            case "1":
                _character = new Wizard(name);
                break;
            case "2":
                _character = new Archer(name);
                break;
            case "3":
                _character = new Warrior(name);
                break;
            case "4":
                _character = new Rogue(name);
                break;
            default:
                Console.WriteLine("Select a number 1 through 4");
                Pause();
                return;
        }
        Console.Clear();
        Console.WriteLine("=== RPG BATTLE SIM ===");
        Console.WriteLine();
        Console.WriteLine($"Welcome, {name} the {_character.GetType().Name}!");
        Console.WriteLine();
        Pause();
    }

    private void SaveGame(string filename)
    {
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }

        if (_character == null)
        {
            Console.WriteLine("No character to save!");
            return;
        }

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_character.Serialize());
        }
    }

    private void LoadGame(string filename)
    {
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }

        if (!File.Exists(filename))
        {
            Console.WriteLine("Save file does not exist!");
            return;
        }

        string line = File.ReadAllText(filename).Trim();
        if (string.IsNullOrEmpty(line))
        {
            Console.WriteLine("Save file is empty!");
            return;
        }

        try
        {
            _character = Character.Deserialize(line);
            Console.WriteLine($"Loaded character: {_character.GetName()} the {_character.GetType().Name}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading character: {ex.Message}");
        }
    }
    private void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
