//Character.cs
public abstract class Character
{
    protected string _name;
    protected string _weapon;
    protected int _health;
    protected int _maxHealth;
    protected int _attack;
    protected int _defense;
    protected int _expThreshold;
    protected int _exp;
    protected int _totalExp;
    protected int _level;

    public Character(string name, string weapon, int health, int maxHealth, int attack, int defense, int threshold, int exp, int level)
    {
        _name = name;
        _weapon = weapon;
        _health = health;
        _maxHealth = maxHealth;
        _attack = attack;
        _defense = defense;
        _expThreshold = threshold;
        _exp = exp;
        _level = level;
    }

    // Getters and Setters
    public string GetName() => _name;
    public void SetName(string name) => _name = name;

    public int GetHealth() => _health;

    public int GetDefense() => _defense;

    public int GetLevel() => _level;

    // Combat methods for Polymorphism
    public virtual int CalculateAttack() => _attack;

    public virtual void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0) _health = 0;
    }

    public virtual void Recover()
    {
        _health = _maxHealth;
    }

    public void GainExp(int amount)
    {
        _exp += amount;
        bool leveledUp = false;
        while (_exp >= _expThreshold)
        {
            _exp -= _expThreshold;
            _level++;
            _expThreshold = (int)(_expThreshold * 1.5);
            _exp = 0;
            _maxHealth += 15;
            _health = _maxHealth;
            _defense += 3;
            _attack += 2;
            leveledUp = true;
        }

        if (leveledUp)
        {
            Console.Clear();
            Console.WriteLine("=== RPG BATTLE SIM ==="); ;
            Console.WriteLine($"Character: {_name}");
            Console.WriteLine($"Level: {_level}");
            Console.WriteLine($"Health: {_health}/{_maxHealth}");
            Console.WriteLine();
            Console.WriteLine($"{_name} the {GetType().Name} leveled up! LEVEL {_level}: {_exp}/{_expThreshold}");
        }
    }

    // Serialization
    public override string ToString()
    {
        return $"{GetType().Name}|{_name}|{_weapon}|{_health}|{_maxHealth}|{_attack}|{_defense}|{_expThreshold}|{_exp}|{_level}";
    }

    public virtual string Serialize() => ToString();

    public static Character Deserialize(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length != 10)
            throw new Exception("Invalid save data format.");

        string type = parts[0];
        string name = parts[1];
        string weapon = parts[2];

        int health = int.Parse(parts[3]);
        int maxHealth = int.Parse(parts[4]);
        int attack = int.Parse(parts[5]);
        int defense = int.Parse(parts[6]);
        int threshold = int.Parse(parts[7]);
        int exp = int.Parse(parts[8]);
        int level = int.Parse(parts[9]);

        Character character = type switch
        {
            "Wizard" => new Wizard(name),
            "Archer" => new Archer(name),
            "Warrior" => new Warrior(name),
            "Rogue" => new Rogue(name),
            _ => throw new Exception("Unknown character type")
        };

        // Overwrite stats with saved data
        character._weapon = weapon;
        character._health = health;
        character._maxHealth = maxHealth;
        character._attack = attack;
        character._defense = defense;
        character._expThreshold = threshold;
        character._exp = exp;
        character._level = level;

        return character;
    }

}
