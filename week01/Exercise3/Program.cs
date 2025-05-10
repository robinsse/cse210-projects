using System;

class Program
{
    static void Main(string[] args)
    {

        //Generate random number for magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //Initialize guess variable
        int guess = -1;

        //while Loop
        while (guess != magicNumber)
        {
            //Ask user for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            //If statement Higher or Lower
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }

        }
    }
}