class Person
{
    private string _firstname;

    private string _lastname;

    private int _age;

    public Person()
    {
        _firstname = "";
        _lastname = "";
        _age = 0;
    }


    public Person(string firstName, string lastName, int age)
    {
        _firstname = firstName;
        _lastname = lastName;
        _age = age;
    }

    public string GetPersonInformation()
    {
        return $"{_firstname} {_lastname} age: {_age}";
    }




}