using System;

class Program
{
    static void Main(string[] args)
    {
        Random numberGenerator = new Random();
        int number = numberGenerator.Next(1, 101);

        //Console.WriteLine("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber);

        bool keepGoing = true;
        while (keepGoing)
        {
        Console.WriteLine("Guess the magic number: ");
        string magicGuess = Console.ReadLine();
        int guess = int.Parse(magicGuess);

        if (guess > number)
        {
            Console.WriteLine("Lower");
        } 
        else if (guess < number) 
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You got it!");
            keepGoing = false;
        }
        }
        
    }
}