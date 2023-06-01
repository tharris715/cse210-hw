using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Activity act = new Activity();
        

        
    
    
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu:");

        string choice = Console.ReadLine();

        while (choice != "4") {
            if (choice == "1") {
                Breathing breath = new Breathing();
                breath.DisplayStartMesssage(); // not working
                int breathSeconds = Int32.Parse(Console.ReadLine());
                breath.SetDuration(breathSeconds);
                breath.ActiveBreathing(breathSeconds);
                breath.DisplayFinishMesssage(); // not working


            }
            else if (choice == "2") {

            }
            else if (choice == "3") {
                Listing myList = new Listing("prompt");

            }
            


        }
    
    
    
    
    
    
    }
}