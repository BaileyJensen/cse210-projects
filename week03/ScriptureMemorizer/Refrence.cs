using System.Data;

public class Refrence
{
    private string _book;

    private int _chapter;

    private int _verse;



   public Refrence(string book, int chapter, int verse)
    {
        _book =  book;
        _chapter =  chapter;
        _verse = verse;
        
    }

    public string GetDisplayText()
    {
        string fullRefrence = ($"{_book} {_chapter} : {_verse}");
        return fullRefrence;
    }

}