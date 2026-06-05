using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        while (userChoice != 4)
        {
            

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Please select an option:");
       userChoice = int.Parse(Console.ReadLine());

       if (userChoice == 1)
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
            }

        else if (userChoice == 2)
            {
                ListingActivity activity2 = new ListingActivity();
                activity2.Run();
            }

        else if (userChoice == 3)
            {
                ReflectingActivity activity3 = new ReflectingActivity();
                activity3.Run();
            }

            else
            {
                break;
            }


        }

        

    }
}