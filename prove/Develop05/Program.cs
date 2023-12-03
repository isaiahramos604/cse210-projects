using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static Manager manager = new Manager();
    

    static void Main(string[] args)
    {
        bool showMainMenu = true;
        SaveAndLoad sL1 = new SaveAndLoad();

        while (showMainMenu)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event ");
            Console.WriteLine("6. Show user's score");
            Console.WriteLine("7. Quit ");
            Console.Write("Choose one!");

            int mainChoice;
            if (int.TryParse(Console.ReadLine(), out mainChoice))
            {
                switch (mainChoice)
                {
                    case 1:
                        ShowSubMenu();
                        break;
                    case 2:
                        manager.ListGoals();
                        Console.ReadKey();
                        break;
                    case 3:
                        
            {
                Console.WriteLine("Enter the filename to save your goals (without extension):");
                string userchoosenfileName = Console.ReadLine();
                sL1.SaveGoalsToFile(manager.goalsList, userchoosenfileName);
                Console.ReadLine();
            }
                        break;
                    case 4:
                Console.WriteLine("Enter the filename to load your goals (without extension):");
                string userFileName = Console.ReadLine();
                manager.goalsList = sL1.LoadGoalsFromFile(userFileName);
                Console.ReadLine();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        Console.WriteLine($"User's score: {manager.CalculateScore()}");
                        Console.ReadLine();
                        break;
                    case 7:
                        showMainMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadLine();
            }
        }
    }

    static void ShowSubMenu()
    {
        bool showSubMenu = true;

        while (showSubMenu)
        {
            Console.Clear();
            Console.WriteLine("Select your goal");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int subChoice;
            if (int.TryParse(Console.ReadLine(), out subChoice))
            {
                switch (subChoice)
                {
                    case 1:
                        AddSimpleGoal();
                        break;
                    case 2:
                        AddEternalGoal();
                        break;
                    case 3:
                        AddChecklistGoal();
                        break;
                    case 4:
                        showSubMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadLine();
            }
        }
    }

    static void AddSimpleGoal()
    {
        Console.WriteLine("Enter description for a Simple Goal:");
        string simpleDescription = Console.ReadLine();
        Console.WriteLine("Enter points for your Simple Goal:");
        int simplePoints;
        if (!int.TryParse(Console.ReadLine(), out simplePoints))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.ReadLine();
            return;
        }

        SimpleGoal simpleGoal = new SimpleGoal(false, simpleDescription, simplePoints);
        manager.AddGoal(simpleGoal);
    }

    static void AddEternalGoal()
    {
        Console.WriteLine("Enter description for an Eternal Goal:");
        string eternalDescription = Console.ReadLine();
        Console.WriteLine("Enter points for your Eternal Goal:");
        int eternalPoints;
        if (!int.TryParse(Console.ReadLine(), out eternalPoints))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.ReadLine();
            return;
        }

        EternalGoal eternalGoal = new EternalGoal(false, eternalDescription, eternalPoints);
        manager.AddGoal(eternalGoal);
    }

    static void AddChecklistGoal()
    {
        Console.WriteLine("Enter description for a Checklist Goal:");
        string checklistDescription = Console.ReadLine();
        Console.WriteLine("Enter points for each completion:");
        int checklistPoints;
        if (!int.TryParse(Console.ReadLine(), out checklistPoints))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.ReadLine();
            return;
        }
        Console.WriteLine("Enter required completion count:");
        int requiredCompletionCount;
        if (!int.TryParse(Console.ReadLine(), out requiredCompletionCount))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.ReadLine();
            return;
        }
        Console.WriteLine("Enter bonus points for completing the checklist:");
        int bonusPoints;
        if (!int.TryParse(Console.ReadLine(), out bonusPoints))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.ReadLine();
            return;
        }

        ListedGoals checklistGoal = new ListedGoals(false, checklistDescription, checklistPoints, requiredCompletionCount, bonusPoints);
        manager.AddGoal(checklistGoal);
    }

    static void RecordEvent()
    {
        manager.ListGoals();
        Console.WriteLine("Enter the number of the goal you've accomplished:");
        int goalNumber;
        if (!int.TryParse(Console.ReadLine(), out goalNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.ReadLine();
            return;
        }

        manager.RecordEvent(goalNumber);
    }
}

public class Manager
{
    public List<Goal> goalsList = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        goalsList.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("User's Goals:");
        for (int i = 0; i < goalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalsList[i].DisplayStatus()}");
        }
    }

    public void RecordEvent(int goalNumber)
    {
        if (goalNumber > 0 && goalNumber <= goalsList.Count)
        {
            Goal selectedGoal = goalsList[goalNumber - 1];
            int pointsEarned = selectedGoal.RecordEvent();
            Console.WriteLine($"You've earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
        Console.ReadLine();
    }

    public int CalculateScore()
    {
        int score = 0;
        foreach (Goal goal in goalsList)
        {
            if (goal.GetCompletedGoal())
            {
                score += goal.RecordEvent();
            }
        }
        return score;
    }
}

