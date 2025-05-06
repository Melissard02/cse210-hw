using System;

class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        _radius = radius;
        if (radius < 0)
        {
            Console.WriteLine("Error, radius must be > 0");
        }
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}




class Program
{
    static double AddNumbers(double a, double b)
    {
        return a + b;

    }





    static void Main(string[] args)
    {

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");



        //Console.WriteLine("Hello Sandbox World!");
        //Console.WriteLine("Sup");
        // HIGHLIGHT THE WHOLE THING AND TYPE CTR AND / AND IT AUTOMATICALLY COMMENTS IT
        // for(int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine("Hello Bob");
        // }

        // int x = 0;
        // int y= x++;
        // Console.WriteLine(x);
        // Console.WriteLine(y);
        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(4);
        // myNumbers.Add(99);
        // myNumbers.Add(567);


        // foreach(int i in myNumbers)
        // {
        //     Console.WriteLine(i);
        // }

        // double total = AddNumbers(123.98, 1235.76);
        // Console.WriteLine(total);


        // bool done = false;
        // while(!done)
        // {
        //     // ....
        //     done = true;
        // }

        // do
        // {


        // } while(!done);
    }
}