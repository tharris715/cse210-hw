using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment HW1 = new Assignment("Tim Harris", "Inheritance");
        
        // testing assignment
        Console.WriteLine(HW1.GetSummary());

        // testing MathAssignment
        MathAssignment math1 = new MathAssignment("Timothy Harris", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        // testing WritingAssignment
        WritingAssignment essay = new WritingAssignment("Timm Harris", "World War 2","The Causes of World War II");
        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingInformation());

    }
}