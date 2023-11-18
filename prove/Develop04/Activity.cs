using System;

public class Activity
{
    private string _startingMessage = ""; //this is the start of starting message

    public string GetStartingMessage()
    {
        return _startingMessage;
    }

    public void SetStartingMessage(string startingMessage)
    {
        _startingMessage = startingMessage;
    }

    private string _endingMessage = ""; // this is the start of the ending message

    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void SetEndingMessage(string endingMessage)
    {
        _endingMessage = endingMessage;
    }

    private string _Description = ""; //this is the start of description

    public string GetDescription()
    {
        return _Description;
    }

    public void SetDescription(string activityDescription)
    {
        _Description = activityDescription;
    }
    public string GetStartMessage()
    {
        return $"{_startingMessage}"; //this is the starting message
    }

    public string GetActivityDescription()
    {
        return $"{_Description}"; //this is the description 
    }

    public string GetEndMessage()
    {
        return $"{_endingMessage}"; // this is the ending message
    }
    private int timerDuration;
    protected void _Timer()
    {
        Console.WriteLine("How long do you want to your session to last?");
        string valuefromUser = Console.ReadLine();
        int x = int.Parse(valuefromUser);

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(x);
        while (DateTime.Now < endTime)
        {
            
            string s = animationStrings[i];
            Console.Write("\rGet Ready... " + animationStrings[i]);;
            Thread.Sleep(100);
            Console.Write("\b-\b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
             }
             

        }


    }



    public void setTimer()
    {
        _Timer();
    }
    public int GetTimerDuration()
    {
        return timerDuration;
    }
    
}