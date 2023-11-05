using System;

public class Mathassignment : Assignment
{
    private string _textbookSection = "";

    public string GetTextBookSection()
    {
        return _textbookSection;
    }
    public void SetTextBookSection(string section)
    {
        _textbookSection = section;
    }


    private string _problems = "";

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }


}