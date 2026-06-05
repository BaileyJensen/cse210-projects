public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
        :base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area",
        0
        )
    {
        
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine(GetListFromUser());
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        Console.WriteLine(_prompts[index]);



    }

    public string GetListFromUser()
    {
        List<string> response = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string item = Console.ReadLine();
            response.Add(item);
        }
        int _count = response.Count;
        string countmessage = $"You listed {_count} items ";
        return countmessage;
        
    }


}