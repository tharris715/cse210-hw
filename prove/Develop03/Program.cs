using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // This will clear the console
        Console.Clear();


        Scripture scrip = new Scripture();

        scrip.Display();

        // need to first display the scripture - the scripture heading and the actual words are different, the 

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue, or type quit to finish.");
        string choice = Console.ReadLine();
        
        while (choice == "") {
            
            // run code to start hiding words, finish when all words are hidden
            scrip.Hide();
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue, or type quit to finish.");
            choice = Console.ReadLine();
            if (choice.ToLower() == "quit") {
                break;
            }
            
        }
        

    }
}