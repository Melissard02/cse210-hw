

class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceWoman myPoliceWoman = new PoliceWoman("Betty", "crocker", 23);
        Console.WriteLine(myPoliceWoman.GetPersonInformation());
    }

}