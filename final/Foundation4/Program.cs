using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // create activity list
        List<Activity> activities = new List<Activity>();
        
        //create acitivites
        Running activity1 = new Running("Running", 30, 3);
        Bicycle activity2 = new Bicycle("Cycling", 15, 35);
        Swimming activity3 = new Swimming("Swimming", 5, 6);

        // add each activity to the activities list
        activities.Add(activity1);
        activities.Add(activity2);
        activities.Add(activity3);

        // loop through activities list to display summary for each activity
        foreach (Activity act in activities) {
            act.GetSummary();
        }
        
    }
}