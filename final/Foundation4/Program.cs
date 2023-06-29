using System;

class Program
{
    static void Main(string[] args)
    {
        
        Activity activity1 = new Running(30, 3);
        activity1.GetSummary();
    }
}