using System.IO; 

public class GoalManager
{
    List<Goal> _goals;

    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void Start()
    {
           string userInput = "0";

        while (userInput != "6")
        {
            
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice: ");
        userInput = Console.ReadLine();

        if (userInput == "1")
            {
                CreateGoal();
            }
        else if (userInput == "2")
            {
                ListGoalDetails();
            }
        else if (userInput == "3")
            {
                SaveGoals();
            }
        else if (userInput == "4")
            {
                LoadGoals();
                
            }
        else if (userInput == "5")
            {
                RecordEvent();
            }
        }   

    }


    public void ListGoalDetails(){
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("Types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.Write("What kind of goal would you like to create?");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is the description of the goal? ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is this worth?");
        string points = Console.ReadLine();



        if (goalType == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }

        else if (goalType == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to happen to get a bonus? ");
           int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name,description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
      


    

    }

    public void RecordEvent()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("What goal did you accomplish?");
        int choice = int.Parse(Console.ReadLine());
        int index = choice - 1;

        _goals[index].RecordEvent();

        int points = _goals[index].GetPoints();
        _score += points;
        Console.WriteLine($"Congrats! You earned {points}! You now have {_score} points! ");
    
    }

    public void SaveGoals()
    {
        Console.Write("Please enter a filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

public void LoadGoals()
{
    Console.Write("What is the file you'd like to load from? ");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    string[] lines = File.ReadAllLines(filename);

    _goals.Clear();

    foreach (string line in lines)
    {
        string[] parts = line.Split('|');
        string type = parts[0];

        if (type == "Simple goal")
        {
            SimpleGoal goal = new SimpleGoal(parts[1], parts[2], parts[3]);

            bool isComplete = bool.Parse(parts[4]);
            if (isComplete)
            {
                goal.MarkComplete();
            }

            _goals.Add(goal);
        }
        else if (type == "Eternal Goal")
        {
            EternalGoal goal = new EternalGoal(parts[1], parts[2], parts[3]);
            _goals.Add(goal);
        }
        else if (type == "Checklist Goal")
        {
            string[] progress = parts[4].Split('/');

            int completed = int.Parse(progress[0]);
            int target = int.Parse(progress[1]);
            int bonus = int.Parse(parts[5]);

            ChecklistGoal goal =
                new ChecklistGoal(parts[1], parts[2], parts[3], target, bonus);

            goal.SetProgress(completed);

            _goals.Add(goal);
        }
    }

    Console.WriteLine("Goals loaded successfully!");

    ListGoalDetails();
}
}