//Warrior.cs
public class Warrior : Character
{
    public Warrior(string name)
    : base(name, "Iron Sword", 120, 12, 8, 50, 0, 1) { }
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