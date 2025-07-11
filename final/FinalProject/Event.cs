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
        Console.Clear();
        Console.WriteLine("Enemy Encounter!");

        Enemy enemy = GenEnemy();
        EnemyStats(enemy);

        while (player.GetHealth() > 0 && enemy.GetHealth() > 0)
        {
            PlayerTurn(player, enemy);
            if (enemy.GetHealth() <= 0)
            {
                Console.WriteLine($"You defeated the enemy! You earned {enemy.GetGiveExp()} EXP.");
                player.GainExp(enemy.GetGiveExp());
                break;
            }

            EnemyTurn(player, enemy);
            if (enemy.GetHealth() <= 0)
            {
                Console.WriteLine("Game Over. Try Again.");
                break;
            }
        }
    }

    private void EnemyStats(Enemy enemy)
    {
        // Console.Clear();
        Console.WriteLine("Enemy Stats:");
        Console.WriteLine($"Health: {enemy.GetHealth()}");
        Console.WriteLine($"Defense: {enemy.GetDefense()}");
        Console.WriteLine($"Attack: {enemy.GetAttack}");
        Console.WriteLine($"Weapon: {enemy.GetWeapon}");
        Console.WriteLine();
    }

    private void PlayerTurn(Character player, Enemy enemy)
    {

    }

    private void EnemyTurn(Character player, Enemy enemy)
    {

    }
}