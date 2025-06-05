using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment a1 = new Assignment("Grant", "Division");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Janey Smith", "Addition", "7.2", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Dain Brooks", "World History", "The Cause of the Brazilian Revolution");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}