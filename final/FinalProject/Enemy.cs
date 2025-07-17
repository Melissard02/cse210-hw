// Enemy.cs

public class Enemy
{
    protected int _health;
    protected int _defense;
    protected int _attack;
    protected string _weapon;
    protected int _giveExp;
    protected bool _dead;

    public Enemy(int health, int defense, int attack, string weapon, int giveExp)
    {
        _health = health;
        _defense = defense;
        _attack = attack;
        _weapon = weapon;
        _giveExp = giveExp;
    }

    public string GetWeapon() => _weapon;
    public void SetWeapon(string weapon) => _weapon = weapon;
    public int GetHealth() => _health;
    public void SetHealth(int health) => _health = health;
    public int GetAttack() => _attack;
    public void SetAttack(int attack) => _attack = attack;
    public int GetDefense() => _defense;
    public void SetDefense(int defense) => _defense = defense;
    public int GetGiveExp() => _giveExp;
    public void SetGiveExp(int giveExp) => _giveExp = giveExp;
    public bool SetDead(bool dead) => _dead = dead;


    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0) _health = 0;
    }

    public bool IsDead()
    {
        return _health <= 0;
    }

    public override string ToString()
    {
        return $"Enemy with {_health} HP, {_attack} ATK, {_defense} DEF, Weapon: {_weapon}";
    }

}