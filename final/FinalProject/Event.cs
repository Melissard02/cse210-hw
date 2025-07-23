//Event.cs
using System;
public class Event
{
    private Location _currentLocation = Location.Fields;
    private Random _rand = new Random();
    public bool _dead;
    private List<LocationInfo> _locations = new List<LocationInfo>()
    {
        new LocationInfo(Location.Fields, 1, "Fields"),
        new LocationInfo(Location.Caves, 5, "Caves"),
        new LocationInfo(Location.Mountains, 10, "Mountains")
    };
    public void LocationMenu(Character player)
    {
        Console.Clear();
        Console.WriteLine($"=== Where will you go {player.GetName()}? ===");

        List<LocationInfo> availableLocations = _locations
            .Where(loc => player.GetLevel() >= loc.RequiredLevel)
            .ToList();

        for (int i = 0; i < availableLocations.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {availableLocations[i].LocationName}");
        }

        Console.WriteLine("\n> ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= availableLocations.Count)
        {
            _currentLocation = availableLocations[choice - 1].Location;
            Console.WriteLine($"\nYou travel to the {availableLocations[choice - 1].LocationName}... \n");
        }
        else
        {
            Console.WriteLine("Invalid input. I guess stay put then...");
        }

        Pause();

    }
    private Enemy GenEnemy()
    {
        int roll = _rand.Next(0, 100);

        if (roll < 60)
        {
            return new Goblin();
        }
        else if (roll < 95)
        {
            return new Bandit();
        }
        else
        {
            return new Dragon();
        }
    }
    public bool IsPlayerDead(Character player)
    {
        if (player.GetHealth() <= 0)
        {
            _dead = true;
            return true;
        }
        return false;
    }
    public bool IsEnemyDead(Enemy enemy)
    {
        if (enemy.GetHealth() <= 0)
        {
            _dead = true;
            return true;
        }
        return false;
    }
    public void StartBattle(Character player)
    {
        BattleScreen(player);

        Enemy enemy = GenEnemy();
        EnemyStats(enemy);
        while (player.GetHealth() > 0 && enemy.GetHealth() > 0)
        {
            if (!PlayerTurn(player, enemy))
            {
                Console.WriteLine($"{player.GetName()} escaped the battle safely!");
                Pause();
                break;
            }
            if (IsEnemyDead(enemy))
            {
                Console.WriteLine($"{player.GetName()} defeated the enemy! Earned {enemy.GetGiveExp()} EXP.");
                player.GainExp(enemy.GetGiveExp());
                break;
            }

            EnemyTurn(player, enemy);
            if (IsPlayerDead(player))
            {
                Console.WriteLine($"{player.GetName()} has fallen in battle. Game Over.");
                Heal(player);
                Console.WriteLine($"{player.GetName()} has recovered at the inn! Full HP restored.");
                break;
            }
        }
    }
    public void BattleScreen(Character player)
    {
        Console.Clear();
        Console.WriteLine("=== RPG BATTLE SIM ==="); ;
        Console.WriteLine($"Character: {player.GetName()}");
        Console.WriteLine($"Level: {player.GetLevel()}");
        Console.WriteLine($"Health: {player.GetHealth()}");
        Console.WriteLine();
    }
    private void EnemyStats(Enemy enemy)
    {
        Console.WriteLine($"--{enemy.GetName}--");
        Console.WriteLine("Enemy Stats:");
        Console.WriteLine($"Health: {enemy.GetHealth()}");
        Console.WriteLine($"Defense: {enemy.GetDefense()}");
        Console.WriteLine($"Attack: {enemy.GetAttack()}");
        Console.WriteLine($"Weapon: {enemy.GetWeapon()}");
        Console.WriteLine();
    }
    private bool PlayerTurn(Character player, Enemy enemy)
    {
        BattleScreen(player);
        Console.WriteLine("-- Player Turn --");
        BattleMenu();
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Attack(player, enemy);
                Pause();
                return true;
            case "2":
                Heal(player);
                Pause();
                return true;
            case "3":
                return false;
            case "4":
                Console.Clear();
                BattleScreen(player);
                Console.WriteLine();
                EnemyStats(enemy);
                Pause();
                return true;
            default:
                Console.WriteLine("Choose option 1-4");
                Pause();
                return true;
        }
    }
    private void EnemyTurn(Character player, Enemy enemy)
    {
        BattleScreen(player);
        Console.WriteLine("-- Enemy Turn --");
        int damage = Math.Max(enemy.GetAttack() - player.GetDefense(), 1);
        Console.WriteLine($"Enemy dealt {damage} damage!");
        player.TakeDamage(damage);
        Console.WriteLine($"{player.GetName()}'s Health: {player.GetHealth()}. \n");
        Pause();
    }
    private void BattleMenu()
    {
        Console.WriteLine("Choose your Action:");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Heal");
        Console.WriteLine("3. Run");
        Console.WriteLine("4. View Enemy Stats (Takes 1 turn) \n");
        Console.Write("> ");
    }
    private void Pause()
    {
        Console.WriteLine("Press enter to continue... ");
        Console.ReadLine();
    }
    private void Attack(Character player, Enemy enemy)
    {
        Console.Clear();
        BattleScreen(player);
        Console.WriteLine("-- Player Turn --");
        int damage = Math.Max(player.CalculateAttack() - enemy.GetDefense(), 1);
        Console.WriteLine($"{player.GetName()} deals {damage} damage!");
        enemy.TakeDamage(damage);
        Console.WriteLine($"Enemy's Current Health: {enemy.GetHealth()}.\n");
    }
    private void Heal(Character player)
    {
        player.Recover();
        Console.Clear();
        BattleScreen(player);
        Console.WriteLine("-- Player Turn --");
        Console.WriteLine("Health Recovered");
    }
    
}