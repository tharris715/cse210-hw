using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // inititate variables needed for program
        Load loading = new Load();
        string choice = "";
        List<string> stringGoals = new List<string>();
        List<Goal> createdGoals = new List<Goal>();

        while (choice != "6") {
            // Display point amount
            
            Console.WriteLine($"You have {loading.GetTotalPoints()} points.\n");

            // menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            // create new goals
            if (choice == "1") {
                Console.Write("The types of Goals are: \n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\n   4. Anti Goal\nWhich type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                if (goalType == "1") {
                    SimpleGoal simple = new SimpleGoal();
                    createdGoals.Add(simple);
                    string simpleString = simple.GetStringRepresentation();
                    stringGoals.Add(simpleString);
                }
                else if (goalType == "2") {
                    EternalGoal eternal = new EternalGoal();
                    createdGoals.Add(eternal);
                    string eternalString = eternal.GetStringRepresentation();
                    stringGoals.Add(eternalString);
                }
                else if (goalType == "3") {
                    ChecklistGoal check = new ChecklistGoal();
                    createdGoals.Add(check);
                    string checklistString = check.GetStringRepresentation();
                    stringGoals.Add(checklistString);
                }
                else if (goalType == "4") {
                    AntiGoal anti = new AntiGoal();
                    createdGoals.Add(anti);
                    string antiString = anti.GetStringRepresentation();
                    stringGoals.Add(antiString);
                }
                else {
                    Console.WriteLine("Invlaid choice.");
                }
            }
            // list the currently available goals
            else if (choice == "2") {
                int count = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in createdGoals) {
                    Console.WriteLine($"{count}. {DisplayGoal(goal)}");
                    count += 1;
                }
            }
            // Save goals to a file
            else if (choice == "3") {
                Console.Write("What would you like to name the file? ");
                string fileName = Console.ReadLine();
                    
                using (StreamWriter outputFile = new StreamWriter(fileName)) {
                    outputFile.WriteLine(loading.GetTotalPoints());//start by saving total points
                    foreach (Goal goal in createdGoals) {
                        outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                    } 
                }
            }
            // load goals and points from a file
            else if (choice == "4") {
                createdGoals.Clear();
                Console.Write("What is the name of the file you would like to load? ");
                string fileName = Console.ReadLine();
                createdGoals = loading.Loading(fileName, createdGoals);
                foreach (Goal goal in createdGoals) {
                    stringGoals.Add(goal.GetStringRepresentation());
                }
                loading.SetTotalPoints(int.Parse(File.ReadLines(fileName).First()));

            }
            // record the completion of a goal
            else if (choice == "5") {
                int goalChoice = 0;
                int points = 0;
                int count = 1;
                Console.WriteLine("The goals are:");
                foreach (Goal myGoal in createdGoals) {
                    Console.WriteLine($"{count}. {myGoal.GetName()}");
                    count += 1;
                }
                Console.Write("Which goal did you accomplish? ");
                goalChoice = int.Parse(Console.ReadLine());

                count = 1;
                foreach (Goal myGoal in createdGoals) {
                    if (count == goalChoice) {
                        if (myGoal.GetComplete() != true) {
                            myGoal.IsComplete();
                            points = myGoal.GetPoints();
                        }  
                    }
                    count +=1; 
                }
                // case if goal is done or no goals are available
                if (points == 0) {
                    Console.WriteLine("Goal not available for points. No points awarded.");
                }
                // case if user earned points
                else if (points > 0){
                    Console.WriteLine($"Congratulations! You earned {points} points!");
                }
                // case if user lost points
                else if (points < 0){
                    Console.WriteLine($"You lost {points} points. You'll do better in the future!");
                }
                // change the total point amount
                int tot = loading.GetTotalPoints();
                loading.SetTotalPoints(tot += points);
            }
        }
    
        static string DisplayGoal(Goal goal) {
            if (goal.GetGoalType() == "ChecklistGoal") {
                if (goal.GetComplete() == true) {
                    return $"[x] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {goal.GetTimesComplete()}/{goal.GetTimes()}";
                }
                else {
                    return $"[ ] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {goal.GetTimesComplete()}/{goal.GetTimes()}";
                }
            }
            else {
                if (goal.GetComplete() == true) {
                    return $"[x] {goal.GetName()} ({goal.GetDescription()})";
                }
                else {
                    return $"[ ] {goal.GetName()} ({goal.GetDescription()})";
                }
            }
                    
        }
    
    }

}