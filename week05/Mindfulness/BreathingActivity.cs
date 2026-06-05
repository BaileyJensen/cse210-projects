public class BreathingActivity : Activity
{
    public BreathingActivity()
        :base(
        "Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing",
        0
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {

            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }

}