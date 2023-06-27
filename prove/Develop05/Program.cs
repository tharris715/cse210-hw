using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Load loading = new Load();
        
        string choice = "";
        List<string> goals = new List<string>();
        List<Goal> dGoal = new List<Goal>();
        Goal g = new Goal();

        
        while (choice != "6") {
            // Display point amount
            
            Console.WriteLine($"You have {loading.GetTotalPoints()} points.\n");

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
                        SimpleGoal simple = new SimpleGoal();
                        dGoal.Add(simple);
                        string simpleString = simple.GetStringRepresentation();
                        goals.Add(simpleString); // need to get string representation to add to list?
                        break;
                    }
                    else if (goalType == 2) {
                        EternalGoal eternal = new EternalGoal();
                        dGoal.Add(eternal);
                        string eternalString = eternal.GetStringRepresentation();
                        goals.Add(eternalString);
                        break;
                    }
                    else if (goalType == 3) {
                        ChecklistGoal check = new ChecklistGoal();
                        dGoal.Add(check);
                        string checklistString = check.GetStringRepresentation();
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
                        
                        Console.WriteLine($"{count}. [ ] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {goal.GetCheckComplete()}/{goal.GetTimes()}");
                        count += 1;
                    }
                    else {
                        Console.WriteLine($"{count}. [ ] {goal.GetName()} ({goal.GetDescription()})");
                        count += 1;
                    }
                }
                Console.WriteLine();
                //Console.WriteLine($"You have {loading.GetTotalPoints()} points.\n");
            }
            else if (choice == "3") {
                Save saving = new Save();
                saving.Saving(goals, loading.GetTotalPoints());

            }
            else if (choice == "4") {
                Console.Write("What is the name of the file you would like to load? ");
                string fileName = Console.ReadLine();
                dGoal = loading.Loading(fileName);
                foreach (Goal goal in dGoal) {
                    goals.Add(goal.GetStringRepresentation());
                }
                loading.SetTotalPoints(int.Parse(File.ReadLines(fileName).First()));

            }
            else if (choice == "5") {
                g.RecordEvent(dGoal);
            }
        }
    }

    
}