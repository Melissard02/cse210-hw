// Wizard.cs

public class Wizard : Character
{
    public Wizard(string name, string weapon, int health, int attack, int defense, int threshold, int exp, int level = 1) : base(name, weapon, health, attack, defense, threshold, exp, level) { }

    protected int LevelExp;

    public override void GainExp(int amount)
    {
        _exp += amount;
        while (_exp >= _expThreshold)
        {
            _exp -= _expThreshold;
            LevelUp();
        }
    }

    private void LevelUp()
    {
        _level++;
        Console.WriteLine($"{_name} leveled to level {_level}.");

        _attack += 4;
        _defense += 3;
        _health += 13;
        _expThreshold = (int)(_expThreshold * 1.2);
    }
}