using System;

public class Assignment
{
    protected string _studentName = "";
    private string _topic = "";

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string name)
    {
        _studentName = name;        
    } 

    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }


}