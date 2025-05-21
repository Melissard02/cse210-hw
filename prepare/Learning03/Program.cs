using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction();
        Fraction fractionTwo = new Fraction(5);
        Fraction fractionThree = new Fraction(6, 7);

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionThree.GetFractionString());

        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fractionTwo.GetDecimalValue());
        Console.WriteLine(fractionThree.GetDecimalValue());
    }

}