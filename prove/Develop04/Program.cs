using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
    
    
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu:");

        string choice = Console.ReadLine();

        

        while (choice != "4") {
            

            if (choice == "1") {
                BreathingActivity breath = new BreathingActivity("", "", 0);
                

            }
            else if (choice == "2") {
                ReflectionActivity ref = new ReflectionActivity("", "", 0, "", "");

            }
            else if (choice == "3") {
                //ListingActivity breath = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", act1.GetDuration(), GetPrompt());


            }
            


        }
    
    
    
    
    
    
    }
}