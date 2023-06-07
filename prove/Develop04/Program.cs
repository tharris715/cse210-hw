using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        

        string choice = "";

        while (choice != "4") {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu:");

            choice = Console.ReadLine();
            

            if (choice == "1") {
                BreathingActivity breath = new BreathingActivity("", "", 0);
            }
            else if (choice == "2") {
                ReflectionActivity reflect = new ReflectionActivity("", "", 0, "", "");
                
            }
            else if (choice == "3") {
                ListingActivity breath = new ListingActivity("", "", 0);
            }
            


        }
    
    
    
    
    
    
    }
}