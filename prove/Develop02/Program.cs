using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Entry newEntry = new Entry();
        List<string> entryList = new List<string>();
        string journalFile = "journal.txt";
        string choice = "0";
        while (choice != "5")
        {

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. View");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();

            
            if (choice == "1")
            {
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.Display();
                Console.WriteLine(prompt);
                Console.Write("> ");
                newEntry._writing = Console.ReadLine();
                entryList.Add(prompt );
                entryList.Add(" \n");
                entryList.Add(newEntry._writing);
            }

            else if (choice == "2")
            {   
                // Try making a list to store the new entries, and display just those when option 2 is selected
                // This should be able to display entries as well as the journal, but I'm not sure how to do that
                // Currently it just displays the saved journal
                Journal myJournal = new Journal(journalFile);
                myJournal.Load();
                myJournal.Display();

               
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the name of the file you want to load?");
                journalFile = Console.ReadLine();
                Journal myJournal = new Journal(journalFile);
                myJournal.Load();
                
            }
            else if (choice == "4")
            {
                Journal myJournal = new Journal(journalFile);
                myJournal.Save(entryList);
                
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }
        
    }
}