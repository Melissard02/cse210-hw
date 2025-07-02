//Program.cs

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        Menu menu = new Menu(manager);
        
        menu.ShowMain();
    }
}
