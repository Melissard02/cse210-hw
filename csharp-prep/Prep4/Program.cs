using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        bool loopy = true;
        while (loopy)
        {
            Console.Write("Enter number: ");
            string userinput = Console.ReadLine();
            int number = int.Parse(userinput);

            if (number != 0)
            {
                numbers.Add(number);
            }
            else {
                Console.WriteLine("The numbers: " + string.Join(", ", numbers));
                loopy = false;
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        
        Console.WriteLine("The total is: "+ total);

        double avg = numbers.Average();
        Console.WriteLine("The average is: "+ avg);

        int bignum = numbers.Max();
        Console.WriteLine("The biggest number is: "+ bignum);



    }
}