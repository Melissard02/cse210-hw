using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Sandbox World!");

        Console.Write("Input your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Your first name is: {firstName}");
        Console.Write("Input your Last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}