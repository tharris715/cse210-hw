using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Entry newEntry = new Entry();
        string journalFile = "journal.txt";
        List<string> prompts = new List<string> {"What was your favorite part of today?", "What would you redo today if you could?", "What event from today would you like to share with your parents?", "Was there anything unusual about what happened today?", "What was the biggest news event you heard about today?", "What did you do today to become more Christlike?", "Did your children do anything funny or noteworthy today?"};
        PromptGenerator generator = new PromptGenerator(prompts);
        string prompt = generator.Display();
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
                Console.WriteLine(prompt);
                Console.Write("> ");
                newEntry._writing = Console.ReadLine();
                
            }

            else if (choice == "2")
            {
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
                myJournal.Save(prompt, newEntry);
                
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }
        
    }
}