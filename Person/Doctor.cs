class Doctor : Person
{
    private string _tools;

    private double _salary;

    public Doctor(string firstName, string lastName, int age, string tools, double salary) : base(firstName, lastName, age)
    {
        _tools = tools;
        _salary = salary;
    }

    public string GetDoctorInformation()
    {
        return $"Tools: {_tools} :: {GetPersonInformation()}";
    }


    public override string GetPersonInformation()
    {
        return $"I am a Doctor: Tools: {_tools} :: {base.GetPersonInformation()}";
    }

    public override double GetPay()
    {
        return _salary / 12;
    }


}

