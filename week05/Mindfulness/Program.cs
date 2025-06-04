using System;

class Program
{
    static void Main(string[] args)
    {
        string menuOption = "";
        while (menuOption != "4")
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOption = Console.ReadLine();

            if (menuOption == "1")
            {
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity1.StartingMessage();
                activity1.Run();
                activity1.EndingMessage();
            }
            else if (menuOption == "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity2.StartingMessage();
                activity2.Run();
                activity2.EndingMessage();

            }
            else if (menuOption == "3")
            {
                ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity3.StartingMessage();
                activity3.Run();
                activity3.EndingMessage();
            }
            else if (menuOption == "4")
            {
                Console.WriteLine("Your session has ended.");
            }

            else
            {
                Console.WriteLine("This is not a valid option.");
            }

        }

    }
}