using System;

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string bookSection, string problem): base(name,topic)
    {
        _textBookSection = bookSection;
        _problems = problem;
    }

    public string GetHomeWorkList()
    {
        return $"{_textBookSection} Problems {_problems}";
    }
}