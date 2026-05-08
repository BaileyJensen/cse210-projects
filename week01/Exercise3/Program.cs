using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magNum = randomGenerator.Next(1, 101);


    int number = 0;
    do
    {
   
        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        number = int.Parse(guess);
        Console.WriteLine($"Your guess is {guess}");


        if (number > magNum)
        {
            Console.WriteLine("Lower");
        }
        else if (number < magNum)
        {
            Console.WriteLine("Higher");
        }
        else 
        {
            Console.WriteLine("You guessed it!");
        }
    } while (number != magNum);
    }
}