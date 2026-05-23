using System.Runtime.CompilerServices;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    private Refrence _refrence;

    public Scripture()
    {
      string book = "2 Nephi";
      int chapter = 25;
      int verse = 26;
    
     _refrence = new Refrence(book, chapter,verse);

      string fullScripture = "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.";
      string[] partScript = fullScripture.Split(" ");

      foreach (string item in partScript)
      {
        Word newWord = new Word(item);
        _words.Add(newWord);
        
      }
    
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        while (hiddenCount < numberToHide & !IsCompletelyHidden())

     
        {
        int index = _random.Next(_words.Count);
        
             if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                hiddenCount += 1;
            }
           
        }

    }

    public string GetDisplayText()
    {
        string scriptureRefrence = _refrence.GetDisplayText();
        string scriptVerse = "";
        foreach (Word word in _words)
        {
            scriptVerse += word.GetDisplayText() + " ";
        }
        return scriptureRefrence + " " + scriptVerse;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if  (word.IsHidden() == false)
            {
                return false;
                
            }

        }
            return true;
    }
}