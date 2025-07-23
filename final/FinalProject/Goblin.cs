// Goblin.cs

public class Goblin : Enemy
{
    private static Random _rand = new Random();
    public Goblin() : base(0, 0, 0, "", 0, "")
    {
        bool isRare = _rand.Next(0, 100) < 20;

        if (isRare)
        {
            _health = 45;
            _defense = 5;
            _attack = 9;
            _weapon = "Rusty Sword";
            _giveExp = 30;
            _name = "Warrior Goblin";
        }
        else
        {
            _health = 35;
            _defense = 3;
            _attack = 6;
            _weapon = "Dagger";
            _giveExp = 15;
            _name = "Goblin";
        }
    }
    public Goblin(int health, int defense, int attack, string weapon, int giveExp, string name) : base(health, defense, attack, weapon, giveExp, name) { }
    
}