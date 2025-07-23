// Enemy.cs

public class Enemy
{
    protected int _health;
    protected int _defense;
    protected int _attack;
    protected string _weapon;
    protected int _giveExp;
    protected string _name;

    public Enemy(int health, int defense, int attack, string weapon, int giveExp, string name)
    {
        _health = health;
        _defense = defense;
        _attack = attack;
        _weapon = weapon;
        _giveExp = giveExp;
        _name = name;
    }

    public string GetWeapon() => _weapon;
    public int GetHealth() => _health;
    public int GetAttack() => _attack;
    public int GetDefense() => _defense;
    public int GetGiveExp() => _giveExp;
    public string GetName() => _name;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0) _health = 0;
    }

}