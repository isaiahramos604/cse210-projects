using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch(choice)
                {
                    case 1:
                        BreathingActivity breathing1 = new BreathingActivity();

                        breathing1.SetStartingMessage("Welcome to the Breathing Activity.");
                        breathing1.SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                        Console.WriteLine(breathing1.GetStartingMessage());
                        Console.WriteLine(breathing1.GetDescription());
                        Console.Write("Enter duration (in seconds) for the Breathing Activity: ");
                        if (int.TryParse(Console.ReadLine(), out int duration))
                        {
                            breathing1.PerformBreathingCycle(duration);
                            Console.WriteLine("");
                            breathing1.SetEndingMessage($"You have completed {duration} seconds of the Breathing Activity!");
                            Console.WriteLine(breathing1.GetEndMessage());


                        }
                       



                    break;

                    case 2:
                        Reflection reflection1 = new Reflection();
                        reflection1.SetStartingMessage("Welcome to the Reflection Activity.");
                        reflection1.SetDescription("This activity will help you reflect on times in your life you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                        Console.WriteLine(reflection1.GetStartMessage());
                        Console.WriteLine(reflection1.GetDescription());
                        reflection1.setTimer();

                       
                        List<string> retrievedFirstPrompts = Reflection.GetFirstPrompts();
                        Random random = new Random();
                        int randomIndex = random.Next(retrievedFirstPrompts.Count);
                        string randomPrompt1 = retrievedFirstPrompts[randomIndex];

                        Console.WriteLine("Times up for First Prompts!");
                        Console.WriteLine("");
                        Console.WriteLine("Consider the following First Prompt: ");
                        Console.WriteLine("");
                        Console.WriteLine($"---{randomPrompt1}---");
                        Console.WriteLine("Press Enter to continue...");

                        
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                        
                        List<string> retrievedSecondPrompts = Reflection.GetSecondPrompts();
                        Console.WriteLine("Consider the following Second Prompts: ");
                        Console.WriteLine("");

                        for (int i = 0; i < 2; i++)
                        {
                            randomIndex = random.Next(retrievedSecondPrompts.Count);
                            string randomPrompt2 = retrievedSecondPrompts[randomIndex];
                            Console.WriteLine($"---{randomPrompt2}---");
                        }

                        Console.WriteLine("Press Enter to finish...");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }


;
                        

                    break;

                    case 3:
                        ListingActivity listing1 = new ListingActivity();
                        listing1.SetStartingMessage("Welcome to the Listing Activity");
                        listing1.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                        
                        Console.WriteLine(listing1.GetStartMessage());
                        Console.WriteLine(listing1.GetDescription());

                        Console.Write("Enter duration (in seconds) for the Listing Activity: ");
                        if (int.TryParse(Console.ReadLine(), out int listingDuration))
                        {
                            listing1.RunListingActivity(listingDuration);

                            
                            listing1.SetEndingMessage($"You have completed {listingDuration} second of the listing Activity");
                            Console.WriteLine("");

                            Console.WriteLine(listing1.GetEndMessage());

                            
                        }


                        


                        
    

                    

                    break;

                    case 4:
                     Console.WriteLine("Goodbye!");
                     return;
                   

                }
            }



        }
    }
}