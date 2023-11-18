

public class BreathingActivity : Activity
{





    public void PerformBreathingCycle(int durationInSeconds)
    {
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");




        Console.WriteLine($"Starting Breathing cycle for {durationInSeconds} seconds.");

        int breathDuration = durationInSeconds / 2; 

        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
        

        while (DateTime.Now < endTime)
        {


            Console.WriteLine($"Breathe in...");
            
            Thread.Sleep(breathDuration * 1000); 
            

            if (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe out... ");
                
                Thread.Sleep(breathDuration * 1000); 
                
            }
        }

    }




   
}
