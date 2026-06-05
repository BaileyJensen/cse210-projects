using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Activity
{
    protected string _name;

    protected string _description;

    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name= name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds would you like the activity?");
        _duration = int.Parse(Console.ReadLine());
       
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(5);


    }

    public void ShowSpinner(int seconds)
    {

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

         while (DateTime.Now <endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i= seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}