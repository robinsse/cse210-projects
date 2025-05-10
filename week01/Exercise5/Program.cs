using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int parameter)
    {
        int squared = parameter * parameter;
        return squared;
    }

    static void DisplayResult()
    {
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);
        Console.WriteLine($"{userName}, the square of your number is {squared}. ");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }
}