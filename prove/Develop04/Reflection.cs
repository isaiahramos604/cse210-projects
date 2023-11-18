using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Reflection : Activity
{

    
    
    
    private static List<string> firstPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    public static List<string> GetFirstPrompts()
    {
        return firstPrompts;
    }
   
    private static List<string> secondPrompts = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    public static List<string> GetSecondPrompts()
    {
        return secondPrompts;
    }


   
    public void DisplaySecondPromptsOnTimer(List<string> retrievedSecondPrompts)
    {
        int timerValue = GetTimerDuration();

        if (timerValue == 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(retrievedSecondPrompts.Count);
            string randomPrompt2 = retrievedSecondPrompts[randomIndex];

            Console.WriteLine("Times up!");
            Console.WriteLine("");
            Console.WriteLine("Consider the following Second Prompt: ");
            Console.WriteLine("");
            Console.WriteLine($"---{randomPrompt2}---");
            Console.WriteLine("Press Enter when you are ready to continue or type quit to exit.");

            
            Console.ReadLine();
            
        }
    }
    

    
}

    




        


    

    
    


    
