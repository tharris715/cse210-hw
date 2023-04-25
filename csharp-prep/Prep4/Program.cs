using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int response = -1;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (response != 0)
        {
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());
            
            if (response != 0)
            {
                numbers.Add(response);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        float average = ((float)sum) / numbers.Count();
        Console.WriteLine($"The average is: {average}");
        
        int min = 999999;
        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The lowest positive number is {min}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        Console.WriteLine("Here is the sorted list:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }


    }
}