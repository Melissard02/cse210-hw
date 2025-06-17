
class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bob", "Lemi", 34);
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceWoman myPoliceWoman = new PoliceWoman("Betty", "Crocker", 23, "batton", 65, 73.23);
        // Console.WriteLine(myPoliceWoman.GetPersonInformation());
        // Console.WriteLine(myPoliceWoman.GetPoliceWomanInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 43, "Knife", 500000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceWoman);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }

    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
        Console.WriteLine($"Salary: {person.GetPay()}");
    }

}