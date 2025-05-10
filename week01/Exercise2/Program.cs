using System;
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentageText = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageText);
        int lastDigit = gradePercentage % 10;

        string letter = "";
        string refinedLetter = "";

        //Find letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Find if + or - exists
        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            refinedLetter = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            refinedLetter = "-";
        }
        else
        {
            refinedLetter = "";
        }

        //Grade Statement
        Console.WriteLine($"You got a {letter}{refinedLetter}. ");

        //Cheerleader Statement
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations. You passed! ");
        }
        else
        {
            Console.WriteLine("You should try again to pass the class. You can do it!");
        }
    }
}