

class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceWoman myPoliceWoman = new PoliceWoman("Betty", "Crocker", 23, "batton");
        // Console.WriteLine(myPoliceWoman.GetPersonInformation());
        Console.WriteLine(myPoliceWoman.GetPoliceWomanInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 43, "Knife");
        Console.WriteLine(myDoctor.GetDoctorInformation());

    }

}