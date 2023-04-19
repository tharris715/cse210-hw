using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string grade = Console.ReadLine();
        float grade1 = float.Parse(grade);
        string letter = "";

        if (grade1 >= 90)
        {
            letter = "A";
        }
        else if (grade1 < 90 && grade1 >= 80)
        {
            letter = "B";
        }
        else if (grade1 < 80 && grade1 >= 70)
        {
            letter = "C";
        }
        else if (grade1 < 70 && grade1 >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade was: {letter}");

        if (grade1 >= 70)
        {
            Console.WriteLine("You passed, congratulations!");
        }
        else
        {
            Console.WriteLine("You did not pass the course, try better next time.");
        }
        




    }
}