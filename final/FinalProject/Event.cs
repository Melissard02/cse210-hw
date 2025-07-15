//Event.cs
using System;
public class Event
{
    private Random _rand = new Random();
    private Enemy GenEnemy()
    {
        int health = _rand.Next(30, 61);
        int attack = _rand.Next(5, 16);
        int defense = _rand.Next(2, 8);
        string weapon = "Sword";
        int giveExp = _rand.Next(10, 31);

        return new Enemy(health, defense, attack, weapon, giveExp);
    }
    public void StartBattle(Character player)
    {
        BattleScreen(player);

        Enemy enemy = GenEnemy();
        EnemyStats(enemy);
        while (player.GetHealth() > 0 && enemy.GetHealth() > 0)
        {
            PlayerTurn(player, enemy);
            EnemyTurn(player, enemy);
            if (enemy.GetHealth() <= 0)
            {
                Console.WriteLine($"You defeated the enemy! You earned {enemy.GetGiveExp()} EXP.");
                player.GainExp(enemy.GetGiveExp());
                break;
            }


            if (player.GetHealth() <= 0)
            {
                Console.WriteLine("You have fallen in battle. Game Over.");
                // player.Heal(player.GetMaxHealth());
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
        Console.WriteLine($"Health: {player.GetHealth}");
        Console.WriteLine();
    }
    private void EnemyStats(Enemy enemy)
    {
        Console.WriteLine();
        Console.WriteLine("Enemy Stats:");
        Console.WriteLine($"Health: {enemy.GetHealth()}");
        Console.WriteLine($"Defense: {enemy.GetDefense()}");
        Console.WriteLine($"Attack: {enemy.GetAttack()}");
        Console.WriteLine($"Weapon: {enemy.GetWeapon()}");
        Console.WriteLine();
    }
    private void PlayerTurn(Character player, Enemy enemy)
    {
        Console.WriteLine("Player Turn\n");
        int damage = Math.Max(player.CalculateAttack() - enemy.GetDefense(), 1);
        Console.WriteLine($"Enemy takes {damage} damage!");
        enemy.TakeDamage(damage);
        Console.WriteLine($"Enemy Health: {enemy.GetHealth()}.\n");
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();
    }
    private void EnemyTurn(Character player, Enemy enemy)
    {
        Console.WriteLine("Enemy Turn\n");
        int damage = Math.Max(enemy.GetAttack() - player.GetDefense(), 1);
        Console.WriteLine($"{player.GetName()} takes {damage} damage!");
        player.TakeDamage(damage);
        Console.WriteLine($"{player.GetName()} Health: {player.GetHealth()}");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }
    
}