using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is the grade percentage? ");
        string userinput = Console.ReadLine();
        int grade = int.Parse(userinput);
        if (grade >= 90){
            Console.Write("You got an A!");
        }
        else if (grade >= 80){
            Console.Write("You got a B!");
        }
        else if (grade >= 70){
            Console.Write("You got a C!");
        }
        else if (grade >= 60){
            Console.Write("You got a D. Try harder next time!");
        }
        else {
            Console.Write("You got an F. You failed :(");
        }
    }
}