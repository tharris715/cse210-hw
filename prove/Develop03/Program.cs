using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // This will clear the console
        Console.Clear();

        Reference header = new Reference("2 Nephi", 2, 25);
        Scripture scrip = new Scripture(header);
        Word word = new Word(scrip);
        

        scrip.SetScripture("Adam fell that men might be and men are that they might have joy.");
        header.SetReference("2 Nephi", 2, 25);

        scrip.Display();

        // need to first display the scripture - the scripture heading and the actual words are different, the 

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue, or type quit to finish.");
        string choice = Console.ReadLine();
        
        while (choice == "") {
            
            // run code to start hiding words, finish when all words are hidden
            scrip.Hide();
            word.GetText();
            Console.WriteLine($"{word.hideStringText}");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue, or type quit to finish.");
            choice = Console.ReadLine();
            if (choice.ToLower() == "quit" || !word._hideString.Contains(true)) {
                break;
            }
            
        }
        

    }
}