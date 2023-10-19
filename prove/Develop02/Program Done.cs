using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>
        {
            "How are you feeling today?",
            "What do you want to do better today?",
            "What can you do differently today?",
            "What was the best part of your day today?",
            "What can you ask Heavenly Father to help you with?"
        };

        Random random = new Random();
        bool running = true;
        List<string> userResponses = new List<string>(); 

        while (running)
        {
            Console.WriteLine("Please Select From the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string valuefromUser = Console.ReadLine();

            if (int.TryParse(valuefromUser, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        int randomIndex = random.Next(prompts.Count);
                        string randomPrompt = prompts[randomIndex];
                        Console.WriteLine(randomPrompt);
                        DateTime theCurrentTime = DateTime.Now;
                        string timeStamp = theCurrentTime.ToShortDateString();

                        string userResponse = Console.ReadLine();
                        userResponses.Add($"{timeStamp}: {randomPrompt} - {userResponse}");
                        break;
                    case 2:
                        
                        Console.WriteLine("User Responses:");
                        foreach (string response in userResponses)
                        {
                            Console.WriteLine(response);
                        }
                        break;
                    case 3:
                        
                        Console.WriteLine("Please enter your file name.");

                        string LoadFilename = Console.ReadLine();
                        LoadSavedFiles(userResponses, LoadFilename);
                        break;
                    case 4:
                        
                        UserSaveFile(userResponses);
                        break;
                    case 5:
                        
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static void UserSaveFile(List<string> userResponses)
    {
        Console.WriteLine("What would you like to name your save file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string response in userResponses)
            {
                outputFile.WriteLine(response);
            }
            Console.WriteLine("User responses saved to " + filename);
            
        }
        
    }
    static void LoadSavedFiles(List<string> userResponses, string filename)
    {
        if (File.Exists(filename))
        {
            userResponses.Clear();
            userResponses.AddRange(File.ReadAllLines(filename));
            Console.WriteLine($"{filename} loaded!");

        }




    }
}

