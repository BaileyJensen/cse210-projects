using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Linq;
 


class Program
{
    static void Main(string[] args)
    {


    int userInput = -1;
        List<int> numbers = new List<int>();
    do
    {
        Console.WriteLine("Please enter a list of numbers. Type '0' when done.");
        userInput = int.Parse(Console.ReadLine());
        if (userInput != 0)
        {
        numbers.Add(userInput);
        }
        int count =(numbers.Count);
    } while (userInput != 0); 
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double average = ((double)sum/numbers.Count);
        Console.WriteLine($"The average is: {average}");
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }

}