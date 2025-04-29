using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        string result = DisplayResult(userName, square);
        Console.WriteLine(result);

    }

    static string DisplayWelcome()
    {
        string welcome = "Welcome to the Program!";
        return welcome;
    }


    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string number = Console.ReadLine();
        return int.Parse(number);
    }

    static int SquareNumber(int favNumber)
    {
        return favNumber * favNumber;
    }

    static string DisplayResult(string userName, int square)
    {
        return userName +", the square of your number is "+ square;
    }







}