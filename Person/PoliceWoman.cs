class PoliceWoman : Person
{
    private string _weapons;

    private int _hoursWorked;

    private double _hourlyWage;

    public PoliceWoman(string firstName, string lastName, int age, string weapons, int hoursWorked, double hourlyWage) : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hoursWorked = hoursWorked;
        _hourlyWage = hourlyWage;

    }

    public string GetPoliceWomanInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }

    public override string GetPersonInformation()
    {
        return $"I am a Police Officer : Weapons: {_weapons} :: {base.GetPersonInformation()}";
    }

    public override double GetPay()
    {
        double pay = _hourlyWage * _hoursWorked;

        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }

        return pay;
    }
}