using System;

class Program
{
    static void Main(string[] args)
    {

        /// Still NEED TO GET SPECIFICS FOR EACH EVENT INCLUDED, i.e. weather/speaker/capacity



        // create addresses and events
        List<Event> events = new List<Event>();
        Address address1 = new Address("1624 Runian Ln", "Stenford", "WA", "USA");
        Address address2 = new Address("78432 Crystin Way", "Washington D.C.", "DC", "USA");
        Address address3 = new Address("1983 Skywalker Dr", "Ewok Village", "Sector G65", "Endor");
        Event lecture = new Lectures("Lecture", "A speculation on Nano Particles", "From physical augmentations to curing cancer, we'll think about all kinds of fun things to test our nanoparticles on!", "July 23 2024", "3:00 PM - 5:00 PM", address1.GetAddress(), "Cecil G. Bagsworth III", 432);
        Event reception = new Receptions("Reception", "Smedry Wedding Reception", "Come celebrate the wedding of Alcatraz Smedry and Bastille Dartmoor. Things will break, but not your hearts.", "April 25th 2025", "11:00 AM - 3:00 PM", address2.GetAddress(), "SmedryBreaks@nalhalla.com");
        Event outdoor = new Outdoor("Outdoor", "Ewok Fire Dance", "The Emporer is dead! Come celebrate at our surreal forrest floor bon fire location as we celebrate this victory for rebellion!", "May 25th 1983", "8:00 PM - 12:00 AM", address3.GetAddress(), "clear and humid");
        // add events to list to use for loop
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);
        
        Console.Clear();
        int count = 1;
        // display each message type for each event
        foreach (Event ev in events) {
            Console.WriteLine($"Event #{count}");
            Console.WriteLine(ev.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.FullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.ShortDetails());
            Console.WriteLine();
            count += 1;
        }   
    }
}