

using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    public void RunListingActivity(int listingdurationSeconds)
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

        int i = 0;

        List<string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        int listingduration = listingdurationSeconds/ 2;

        DateTime endTime = DateTime.Now.AddSeconds(listingdurationSeconds);

        Random random = new Random();
        int randomIndex = random.Next(listingPrompts.Count);

        



        while (DateTime.Now < endTime)
        {
            
            DateTime startTime = DateTime.Now;
            DateTime endanimatioTime = startTime.AddSeconds(listingduration);
            while (DateTime.Now < endanimatioTime)
            {
            
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(100);
                Console.Write("\b-\b");
                i++;

                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
             

            }




            int randomIndex1 = random.Next(listingPrompts.Count);
            string randomListing1 = listingPrompts[randomIndex1];
            Console.Write($"\r{randomListing1} {animationStrings[i % animationStrings.Count]}");
            
            Thread.Sleep(listingduration * 1000 / 2); 
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
             }

            if (DateTime.Now < endTime)
            {
            int randomIndex2 = random.Next(listingPrompts.Count);
            string randomListing2 = listingPrompts[randomIndex2];
            Console.Write($"{randomListing2} ");
          
            
            Thread.Sleep(listingduration * 1000 / 2); 
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
             }
            }


        }
        
        







    }


}
