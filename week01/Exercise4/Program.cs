using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        //Create list
        List<int> numbers = new List<int>();

        //Initialize number variable
        int number;

        //while Loop
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);

        //Initialize sum and largest variables
        int sum = 0;
        int largest = numbers[0];

        //Compute the sum and find largest
        foreach (int n in numbers)
        {
            sum += n;
            if (n > largest)
            {
                largest = n;
            }
        }

        //Sum statement
        Console.WriteLine($"The sum is {sum}. ");

        //Find average
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is {average}. ");

        //Largest statement
        Console.WriteLine($"The largest number is {largest}. ");

    }
}