using System;

class Program
{
    static void Main(string[] args)
    {
        // create addresses and events
        Address address1 = new Address("1624 Runian Ln", "Stenford", "WA", "USA");
        Address address2 = new Address("78432 Crystin Way", "Washington D.C.", "DC", "USA");
        Address address3 = new Address("1983 Skywalker Dr", "Ewok Village", "Sector G65", "Endor");
        Lectures lecture = new Lectures("Lecture", "A speculation on Nano Particles", "From physical augmentations to curing cancer, we'll think about all kinds of fun things to test our nanoparticles on!", "July 23 2024", "3:00 PM - 5:00 PM", address1.GetAddress(), "Cecil G. Bagsworth III", 432);
        Receptions reception = new Receptions("Reception", "Smedry Wedding Reception", "Come celebrate the wedding of Alcatraz Smedry and Bastille Dartmoor. Things will break, but not your hearts.", "April 25th 2025", "11:00 AM - 3:00 PM", address2.GetAddress(), "SmedryBreaks@nalhalla.com");
        Outdoor outdoor = new Outdoor("Outdoor", "Ewok Fire Dance", "The Emporer is dead! Come celebrate at our surreal forrest floor bon fire location as we celebrate this victory for rebellion!", "May 25th 1983", "8:00 PM - 12:00 AM", address3.GetAddress(), "clear and humid");
        
        
        //Display output to console
        Console.Clear();
        Console.WriteLine($"Event #1");
        Console.WriteLine($"Standard Details: \n{lecture.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details: \n{lecture.LecFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Details: \n{lecture.ShortDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Event #2");
        Console.WriteLine($"Standard Details: \n{reception.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details: \n{reception.RecFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Details: \n{reception.ShortDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Event #3");
        Console.WriteLine($"Standard Details: \n{outdoor.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details: \n{outdoor.OutFullDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Short Details: \n{outdoor.ShortDetails()}");
        Console.WriteLine();
    }
}