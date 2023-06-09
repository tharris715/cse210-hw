using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        

        string choice = "";

        while (choice != "5") {
            // menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start imagine activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();
            // Run activity based on user selection
            if (choice == "1") {
                BreathingActivity breath = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.", 0);
            }
            else if (choice == "2") {
                ReflectionActivity reflect = new ReflectionActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.", 0, "", "");
            }
            else if (choice == "3") {
                ListingActivity breath = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, "");
            }
            else if (choice == "4") {
                ImagineActivity image = new ImagineActivity("Imagine Activity", "This activity will help you imagine or picture things to help ease anxiety and tension. You will be given a scenario to imagine. Use the whole time to continue thinking of new details about the scenario.", 0, "");
            }
        }    
    }
}