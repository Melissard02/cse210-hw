using System;

class Program
{
    // static double AddNumbers(double a, double b)
    // {
    //     return a + b;

    // }





    static void Main(string[] args)
    {
        // Console.Write("Hello World");

        int duration = 9;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10);
        int sleepTime = 250;

        int count = duration;

        string animationString = "(^_^)(-_-)";


        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");

            // Console.Write(count--);
            // Thread.Sleep(1000);
            // Console.Write("\b");
            
            // Console.Write("+");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");
            // Console.Write("-");
        }


        // Circle myCircle = new Circle(10);
        //myCircle.SetRadius(10);
        // Console.WriteLine($"{myCircle.GetRadius()}");
        //Console.WriteLine($"{myCircle.GetArea()}");

            // Cylinder myCylinder = new Cylinder();
            // myCylinder.SetHeight(10);
            // myCylinder.SetCircle(myCircle);
            // Console.WriteLine($"{myCylinder.GetVolume()}");

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