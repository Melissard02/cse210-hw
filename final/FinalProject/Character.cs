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
    protected int _totalExp;
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

    public void GainExp(int amount)
    {
        _exp += amount;
        Console.WriteLine($"{_name} gained {_exp} EXP. LEVEL {_level}: {_exp}/{_expThreshold}");
        bool leveledUp = false;
        while (_exp >= _expThreshold)
        {
            _exp -= _expThreshold;
            _level++;
            _expThreshold = (int)(_expThreshold * 1.5);
            leveledUp = true;
            //Debug lines
            Console.WriteLine("Hello from the exp while loop");
            Console.WriteLine($"Level: {_level}");
            Console.WriteLine($"Threshold: {_expThreshold}");
            Console.WriteLine($"Bool {leveledUp}");
            Console.ReadLine();
        }

        if (leveledUp)
        {
            Console.WriteLine($"{_name} the {GetType().Name} leveled up! LEVEL {_level}: {_exp}/{_expThreshold}");
        }
    }

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
        string name = parts[1];
        string weapon = parts[2];

        int health = int.Parse(parts[3]);
        int attack = int.Parse(parts[4]);
        int defense = int.Parse(parts[5]);
        int threshold = int.Parse(parts[6]);
        int exp = int.Parse(parts[7]);
        int level = int.Parse(parts[8]);

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
        character._attack = attack;
        character._defense = defense;
        character._expThreshold = threshold;
        character._exp = exp;
        character._level = level;

        return character;
    }

}
