using System;

class Program
{
    static void Main(string[] args)

    {
        Scripture scripture = new Scripture();
        while (true)
        {
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string chose = Console.ReadLine();

        if (chose == "quit")
        {
            Console.WriteLine("Thank you");
            break;
        }

        else if (chose == "")
        {
            
          
            scripture.HideRandomWords(4);
            
        
         if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Great Job!");
                break;
            }
        }

        

        }
    }
}