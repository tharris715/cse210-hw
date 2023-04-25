using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;
        
        while (guess != number)
        {
            Console.WriteLine("Guess a number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Too high, try a lower number.");
                //guess = int.Parse(Console.ReadLine());
            }
            else if (guess < number)
            {
                Console.WriteLine("Too low, try a higher number.");
                //guess = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("You got it!");
            }         
        }
    }
}