using System;
using System.Collections.Generic;
using System.IO;

public class SaveAndLoad 
{
    public List<Goal> LoadGoalsFromFile(string fileName)
    {
        List<Goal> goalsList = new List<Goal>();

        try
        {
            string filePath = $"{fileName}.txt"; // Assuming the file has the same name with .txt extension

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return goalsList; // Return an empty list if file not found
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('-');
                    if (parts.Length == 2)
                    {
                        string description = parts[0].Trim();
                        bool completed = parts[1].Trim().Equals("Completed", StringComparison.OrdinalIgnoreCase);

                    }
                }
            }

            Console.WriteLine($"Goals loaded from file '{filePath}' successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
        }

        return goalsList;
    }

    public void SaveGoalsToFile(List<Goal> goals, string fileName)
    {
        try
        {
            string filePath = $"{fileName}.txt"; // Appending .txt extension to the filename

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var goal in goals)
                {
                    string completionStatus = goal.GetCompletedGoal() ? "Completed" : "Not Completed";
                    writer.WriteLine($"{goal.GetGoal()} - {completionStatus}");
                }
            }

            Console.WriteLine($"Goals and scores saved to file '{filePath}' successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }
}
