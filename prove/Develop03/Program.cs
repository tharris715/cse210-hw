using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // This will clear the console
        Console.Clear();

        // setup variables for the classes
        Reference header = new Reference("2 Nephi", 2, 25);
        Scripture scrip = new Scripture(header);
        Word word = new Word(scrip);
        
        // user can edit scripture and reference in the program without having to go into the classes
        scrip.SetScripture("Adam fell that men might be and men are that they might have joy.");
        header.SetReference("2 Nephi", 2, 25);

        // Display the initial/complete scripture
        scrip.Display(); 

        // Get user input
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue, or type quit to finish.");
        string choice = Console.ReadLine();
        
        // while loop to keep removing words until the user types quit or all the words are hidden
        while (choice == "") {
            
            // run code to start hiding words, finish when all words are hidden
            scrip.Hide();
            word.GetText();
            //Console.WriteLine($"{word.hideStringText}");   test code to see boolean string
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue, or type quit to finish.");
            // If there are no more visibile words kill the program
            if (!word._hideString.Contains(true)) {
                break;
            }
            choice = Console.ReadLine();
            // kill loop if user types quit
            if (choice.ToLower() == "quit") {
                break;
            }
            
        }
        

    }
}