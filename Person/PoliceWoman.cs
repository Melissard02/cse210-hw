class PoliceWoman : Person
{
    private string _weapons;

    public PoliceWoman(string firstName, string lastName, int age, string weapons) : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }

    public string GetPoliceWomanInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }
}