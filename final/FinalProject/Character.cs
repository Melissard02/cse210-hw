//Character.cs
public abstract class Character
{
    protected string _name;
    protected string _weapon;
    protected int _health;
    protected int _attack;
    protected int _defense;
    protected int _expThreshold;
    protected int _exp;
    protected int _level;

    public Character(string name, string weapon, int health, int attack, int defense, int threshold, int exp, int level)
    {
        _name = name;
        _weapon = weapon;
        _health = health;
        _attack = attack;
        _defense = defense;
        _expThreshold = threshold;
        _exp = exp;
        _level = level;
    }

    public Character() { }

    // Getters and Setters
    public string GetName() => _name;
    public void SetName(string name) => _name = name;

    public string GetWeapon() => _weapon;
    public void SetWeapon(string weapon) => _weapon = weapon;

    public int GetHealth() => _health;
    public void SetHealth(int health) => _health = health;

    public int GetAttack() => _attack;
    public void SetAttack(int attack) => _attack = attack;

    public int GetDefense() => _defense;
    public void SetDefense(int defense) => _defense = defense;

    public int GetThreshold() => _expThreshold;
    public void SetThreshold(int threshold) => _expThreshold = threshold;

    public int GetExp() => _exp;
    public void SetExp(int exp) => _exp = exp;

    public int GetLevel() => _level;
    public void SetLevel(int level) => _level = level;

    // Combat methods for Polymorphism
    public virtual int CalculateAttack() => _attack;

    public virtual void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0) _health = 0;
    }

    public abstract void GainExp(int amount);

    // Serialization
    public override string ToString()
    {
        return $"{GetType().Name}|{_name}|{_weapon}|{_health}|{_attack}|{_defense}|{_expThreshold}|{_exp}|{_level}";
    }

    public virtual string Serialize() => ToString();

    public static Character Deserialize(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length != 9)
            throw new Exception("Invalid save data format.");

        string type = parts[0];

        int health = int.Parse(parts[3]);
        int attack = int.Parse(parts[4]);
        int defense = int.Parse(parts[5]);
        int threshold = int.Parse(parts[6]);
        int exp = int.Parse(parts[7]);
        int level = int.Parse(parts[8]);

        return type switch
        {
            "Wizard" => new Wizard(parts[1], parts[2], health, attack, defense, threshold, exp, level),
            "Archer" => new Archer(parts[1], parts[2], health, attack, defense, threshold, exp, level),
            "Warrior" => new Warrior(parts[1], parts[2], health, attack, defense, threshold, exp, level),
            "Rogue" => new Rogue(parts[1], parts[2], health, attack, defense, threshold, exp, level),
            _ => throw new Exception("Unknown character type")
        };
    }
}
