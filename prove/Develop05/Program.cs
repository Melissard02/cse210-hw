// Program.cs

using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        bool running = true;

        while (running)
        {
            int choice = menu.DisplayMenu();
            if (choice == 1)
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.DisplayPrompt();
            }
            else if (choice == 2)
            {
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.DisplayPrompt();
            }
            else if (choice == 3)
            {
                CheckListGoal checkListGoal = new CheckListGoal();
                checkListGoal.DisplayPrompt();
            }
            else if (choice == 4)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Enter a correct value");
            }
        }
    }
}