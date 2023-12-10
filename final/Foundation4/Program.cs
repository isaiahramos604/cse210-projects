using System;

class Program
{
    static void Main(string[] args)
    {
       
        Running runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 20.0);

        int swimmingLaps = 10;
        Swimming swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 30, swimmingLaps);

        
        Console.WriteLine(runningActivity.GetSummary());
        Console.WriteLine(cyclingActivity.GetSummary());
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}