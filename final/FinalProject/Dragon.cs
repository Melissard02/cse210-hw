// Dragon.cs

public class Dragon : Enemy
{
    private static Random _rand = new Random();
    public Dragon() : base(0, 0, 0, "", 0, "")
    {
        bool isRare = _rand.Next(0, 100) < 20;

        if (isRare)
        {
            _health = 300;
            _defense = 70;
            _attack = 60;
            _weapon = "Fire breath";
            _giveExp = 500;
            _name = "Arch Dragon";
        }
        else
        {
            _health = 200;
            _defense = 40;
            _attack = 35;
            _weapon = "Talons";
            _giveExp = 250;
            _name = "Dragon";
        }
    }
    public Dragon(int health, int defense, int attack, string weapon, int giveExp, string name) : base(health, defense, attack, weapon, giveExp, name) { }
}