using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string option = "";
        while (option != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Entry entry = new Entry();
                Console.Write("Date: ");
                entry._date = Console.ReadLine();

                Console.Write("Name one thing that you were thankful for today: ");
                entry._thanks = Console.ReadLine();

                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {entry._promptText}");

                Console.Write("Entry: ");
                entry._entryText = Console.ReadLine();

                Console.Write("Add entry to journal (Y/N)? ");
                string add = Console.ReadLine();

                if (add == "Y")
                {
                    journal.AddEntry(entry);
                    Console.WriteLine("Your entry has been added.");
                }
                else if (add == "N")
                {
                    Console.WriteLine("Your entry was not added.");
                }
                else
                {
                    Console.WriteLine("This is not a valid choice.");
                }

            }

            else if (option == "2")
            {
                journal.DisplayAll();
            }

            else if (option == "3")
            {
                journal.LoadFromFile("journal.txt");
                Console.WriteLine("Journal has been loaded.");
            }

            else if (option == "4")
            {
                journal.SaveToFile("journal.txt");
                Console.WriteLine("Journal has been saved.");
            }

            else if (option == "5")
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("That is not a valid option.");
            }
        }
    }
}