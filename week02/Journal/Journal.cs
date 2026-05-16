using System.IO;
using System.Security.Cryptography.X509Certificates;
public class Journal
{

   
    public List<Entry> _entries = new List<Entry>();
    
    


    public void AddEntry()
    {

        PromptGenerator userPrompt = new PromptGenerator();
        string prompt = userPrompt.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write(">");
        string journalEntry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entry newEntry = new Entry();
        
        newEntry._date = dateText;
        newEntry._entryText = journalEntry;
        newEntry._promptText = prompt;
        
       _entries.Add(newEntry);


    }
   
    public void SaveToFile()
    {
        Console.WriteLine("Please enter a filename: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date} | {e._promptText} | {e._entryText}");

            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What file would you like to read from?");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }


}