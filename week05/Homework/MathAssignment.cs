using System.Reflection.Metadata.Ecma335;

public class MathAssignment : Assignment
{
    private string _textBookSection;

    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problem) : base(studentName,topic)
    {
        _problems = problem;
        _textBookSection = textBookSection;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textBookSection} Problems: {_problems}";
    }
}