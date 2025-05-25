using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Scripture Memorizer!");
            Console.WriteLine("We are going to work on memorizing Psalms 3:5-6");
            Console.WriteLine("How would you like to start?");
            Console.WriteLine("Option 1. Memorize verse 5");
            Console.WriteLine("Option 2. Memorize verse 6");
            Console.WriteLine("Option 3. Memorize both verses");

            Scripture _selectedScripture = null;

            string text5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
            string text6 = "In all thy ways acknowledge him, and he shall direct thy paths.";
            string bothText = ($"{text5} {text6}");

            while (true)
            {
                Console.Write("Which option do you choose? ");
                string _selection = Console.ReadLine();

                if (_selection == "1")
                {
                    Reference psalms5 = new Reference("Psalms", 3, 5);
                    Scripture scripture5 = new Scripture(psalms5, text5);
                    _selectedScripture = scripture5;
                    Console.WriteLine("Psalms 3:5");
                    Console.WriteLine(scripture5.GetDisplayText());
                    break;
                }

                else if (_selection == "2")
                {
                    Reference psalms6 = new Reference("Psalms", 3, 6);
                    Scripture scripture6 = new Scripture(psalms6, text6);
                    _selectedScripture = scripture6;
                    Console.WriteLine("Psalms 3:6");
                    Console.WriteLine(scripture6.GetDisplayText());
                    break;
                }

                else if (_selection == "3")
                {
                    Reference bothVerses = new Reference("Psalms", 3, 5, 6);
                    Scripture scriptureBoth = new Scripture(bothVerses, bothText);
                    _selectedScripture = scriptureBoth;
                    Console.WriteLine("Psalms 3:5-6");
                    Console.WriteLine(scriptureBoth.GetDisplayText());
                    break;
                }

                else
                {
                    Console.WriteLine("This is not a valid option.");
                }
            }

            Console.Write("Enter how many words you want to hide at a time. ");
            int numberToHide = int.Parse(Console.ReadLine());

            while (true)
            {
                if (_selectedScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden! Great job memorizing the scripture!");
                    break;
                }

                Console.Write("Press enter to continue or type 'quit' to exit. ");
                string _enter = Console.ReadLine();

                if (_enter == "")
                {
                    _selectedScripture.HideRandomWords(numberToHide);
                    Console.WriteLine(_selectedScripture.GetDisplayText());
                }
                else if (_enter == "quit")
                {
                    Console.WriteLine("You have stopped playing the game.");
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid entry");
                }
            }

            while (true)
            {
                Console.Write("Would you like to play again? (Y/N) ");
                string again = Console.ReadLine();

                if (again == "Y")
                {
                    Console.Clear();
                    break;
                }
                else if (again == "N")
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    return;
                }
                else
                {
                    Console.Write("That is not a valid entry. Please enter Y or N. ");
                }
            }
        }
    }
}