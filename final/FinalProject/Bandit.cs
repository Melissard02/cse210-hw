// Bandit.cs

public class Bandit : Enemy
{
    private static Random _rand = new Random();
    public Bandit() : base(0, 0, 0, "", 0, "")
    {
        bool isRare = _rand.Next(0, 100) < 20;

        if (isRare)
        {
            _health = 60;
            _defense = 8;
            _attack = 12;
            _weapon = "Iron Axe";
            _giveExp = 40;
            _name = "Bandit Leader";
        }
        else
        {
            _health = 50;
            _defense = 5;
            _attack = 9;
            _weapon = "Worn Axe";
            _giveExp = 24;
            _name = "Bandit";
        }
    }
    public Bandit(int health, int defense, int attack, string weapon, int giveExp, string name) : base(health, defense, attack, weapon, giveExp, name) { }
    
}