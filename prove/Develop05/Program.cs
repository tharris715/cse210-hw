using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        string choice = "";
        List<string> goals = new List<string>();


        while (choice != "6") {
            // menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals"); // needs to list unsaved goals
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            
            
            if (choice == "1") {
                Console.Write("The types of Goals are: \n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\nWhich type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());

                while (goalType < 4) {
                
                    if (goalType == 1) {
                        SimpleGoal simple = new SimpleGoal();
                        string simpleString = simple.GetStringRepresentation(simple.GetGoalType(),simple.GetName(), simple.GetDescription(), simple.GetPoints());
                        goals.Add(simpleString); // need to get string representation to add to list?
                        break;
                    }
                    else if (goalType == 2) {
                        EternalGoal eternal = new EternalGoal("", "", "", 0);
                        //goals.Add(eternal);
                        break;
                    }
                    else if (goalType == 3) {
                        ChecklistGoal check = new ChecklistGoal("", "", "", 0, 0, 0);
                        //goals.Add(check);
                        break;
                    }
                    else {
                        Console.WriteLine("Invlaid choice.");
                        break;
                    }
                }
                

            }
            else if (choice == "2") {
                Console.WriteLine("The goals are: ");
                foreach (string goal in goals) {
                    Console.WriteLine(goal);
                }
            }
            else if (choice == "3") {
                Console.WriteLine("Please enter a file name to save to.");
                string filename = Console.ReadLine();
                //placeholder.Save(filename); // how to write everything to file??
            }
            else if (choice == "4") {
            }
            else if (choice == "5") {
                // savedGoal.RecordEvent(points);
            }
        }
    }
}
