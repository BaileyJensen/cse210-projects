using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int userInput = 0;
        do
        {
            
         Console.WriteLine("Please enter one of the following: ");
         Console.WriteLine("1. Write");
         Console.WriteLine("2. Display");
         Console.WriteLine("3. Load");
         Console.WriteLine("4. Save");
         Console.WriteLine("5. Quit");
         Console.Write("What would you like to do? ");
         userInput = int.Parse(Console.ReadLine());


        

        

            if (userInput == 1)
            {
               journal.AddEntry();

            }
            else if (userInput == 2)
            {
               foreach (Entry entry in journal._entries)
                {
                    entry.Display();
                }    
            }
            else if (userInput == 3)
            {
                journal.LoadFromFile();
            }
            else if (userInput == 4)
            {
                journal.SaveToFile();
            }
            else
            {
                Console.Write("See you next time!");
            } 
        }while (userInput != 5);
        
        
        

    }
}