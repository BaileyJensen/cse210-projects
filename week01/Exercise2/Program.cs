using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        
        string letter = "";
        if (number >= 90)
        {
             letter = "A";
        }
        else if (number >= 80)
        {
             letter = "B";
        }
        else if (number >= 70)
        {
             letter = "C";
        }
        else if (number >= 60)
        {
             letter = "D";
        }
        else
        {
            letter = "F";
        } 
         Console.WriteLine($"Your grade is: {letter}");
        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you didn't pass the course. Next term starts soon! If you study hard, you can pass next time!");
        }
        
    }
}