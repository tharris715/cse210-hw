using System;

class Program
{
    static void Main(string[] args)
    {

        /// Add comments and make teh output look nicer (add Capacity:, Speaker: etc)



        // create addresses and events
        List<Event> events = new List<Event>();
        Address address1 = new Address("1624 Runian Ln", "Stenford", "WA", "USA");
        Address address2 = new Address("78432 Crystin Way", "Washington D.C.", "DC", "USA");
        Address address3 = new Address("1983 Skywalker Dr", "Ewok Village", "Sector G65", "Endor");
        Lectures lecture = new Lectures("Lecture", "A speculation on Nano Particles", "From physical augmentations to curing cancer, we'll think about all kinds of fun things to test our nanoparticles on!", "July 23 2024", "3:00 PM - 5:00 PM", address1.GetAddress(), "Cecil G. Bagsworth III", 432);
        Receptions reception = new Receptions("Reception", "Smedry Wedding Reception", "Come celebrate the wedding of Alcatraz Smedry and Bastille Dartmoor. Things will break, but not your hearts.", "April 25th 2025", "11:00 AM - 3:00 PM", address2.GetAddress(), "SmedryBreaks@nalhalla.com");
        Outdoor outdoor = new Outdoor("Outdoor", "Ewok Fire Dance", "The Emporer is dead! Come celebrate at our surreal forrest floor bon fire location as we celebrate this victory for rebellion!", "May 25th 1983", "8:00 PM - 12:00 AM", address3.GetAddress(), "clear and humid");
        // add events to list to use for loop
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);
        
        
        //Display output to console
        Console.Clear();
        Console.WriteLine($"Event #1");
        Console.WriteLine($"Standard: \n{lecture.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Standard: \n{lecture.LecFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short: \n{lecture.ShortDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Event #2");
        Console.WriteLine($"Standard: \n{reception.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Standard: \n{reception.RecFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short: \n{reception.ShortDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Event #3");
        Console.WriteLine($"Standard: \n{outdoor.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Standard: \n{outdoor.OutFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short: \n{outdoor.ShortDetails()}");
        Console.WriteLine();


    }
}