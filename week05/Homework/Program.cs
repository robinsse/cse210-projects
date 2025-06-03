using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        assignment1.GetSummary();

        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        assignment2.GetSummary();
        assignment2.GetHomeworkList();

        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        assignment3.GetSummary();
        assignment3.GetWritingInformation();

    }
}