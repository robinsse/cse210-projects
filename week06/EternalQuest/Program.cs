using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager(0);
        goalManager.Start();
        Console.WriteLine();
        Console.WriteLine("Thanks for using EternalQuest. Goodbye!");

    }
}