//Warrior.cs

public class Warrior : Character
{
    

    public Warrior(string name, string weapon, int health, int attack, int defense, int threshold, int exp = 0, int level = 1) : base(name, weapon, health, attack, defense, threshold, exp, level) { }

    protected int LevelExp;

    public override void GainExp(int amount)
    {
        //Implement level up logic
    }

}