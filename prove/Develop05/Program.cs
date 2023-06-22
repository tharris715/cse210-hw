using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        string choice = "";
        List<string> goals = new List<string>();
        List<Goal> dGoal = new List<Goal>();
        Goal g = new Goal("", "", "", 0);

        Console.WriteLine("You have xx points.\n");
        while (choice != "6") {
            // menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals"); // needs to list unsaved goals
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals"); // replace whole file each time
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            
            if (choice == "1") {
                Console.Write("The types of Goals are: \n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\nWhich type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());

                while (goalType < 4) {
                
                    if (goalType == 1) {
                        SimpleGoal simple = new SimpleGoal("", "", "", 0, false);
                        dGoal.Add(simple);
                        string simpleString = simple.GetStringRepresentation();
                        goals.Add(simpleString); // need to get string representation to add to list?
                        break;
                    }
                    else if (goalType == 2) {
                        EternalGoal eternal = new EternalGoal("", "", "", 0);
                        dGoal.Add(eternal);
                        string eternalString = eternal.GetStringRepresentation(eternal);
                        goals.Add(eternalString);
                        break;
                    }
                    else if (goalType == 3) {
                        ChecklistGoal check = new ChecklistGoal("", "", "", 0, 0, 0);
                        dGoal.Add(check);
                        string checklistString = check.GetStringRepresentation(check);
                        goals.Add(checklistString);
                        break;
                    }
                    else {
                        Console.WriteLine("Invlaid choice.");
                        break;
                    }
                }
                
            }
            else if (choice == "2") {
                int count = 1;
                Console.WriteLine("The goals are: ");

                foreach (Goal goal in dGoal) {
                    if (goal.GetGoalType() == "ChecklistGoal") {
                        Console.WriteLine($"{count}. [ ] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: 0/X");
                        count += 1;
                    }
                    else {
                        Console.WriteLine($"{count}. [ ] {goal.GetName()} ({goal.GetDescription()})");
                        count += 1;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"You have XX points.\n");
            }
            else if (choice == "3") {
                Save saving = new Save();
                saving.Saving(goals, g.GetTotalPoints());

            }
            else if (choice == "4") {
                Load loading = new Load();
                loading.Loading();

            }
            else if (choice == "5") {
                g.RecordEvent(goals);
            }
        }
    }

    
}
