//Warrior.cs

public class Warrior : Character
{
    protected int LevelExp;

    public Warrior(string name, string weapon, int health, int attack, int defense, int threshold, int exp, int level = 1) : base(name, weapon, health, attack, defense, threshold, exp, level) { }



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
        _defense += 2;
        _health += 14;
        _expThreshold = (int)(_expThreshold * 1.2);
    }

    public override int CalculateAttack()
    {
        // Attack boost when health is low
        if (_health < 30)
        {
            return (int)(_attack * 1.2);
        }

        return _attack;
    }

}