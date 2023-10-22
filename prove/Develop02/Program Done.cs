using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveJournalToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Response: {entry.Response}\n");
            }
        }
        Console.WriteLine("Journal saved to " + filename);
    }

    public void LoadJournalFromFile(string filename)
    {
        entries.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 4)
            {
                Entry entry = new Entry
                {
                    Date = DateTime.Parse(lines[i].Replace("Date: ", "")),
                    Prompt = lines[i + 1].Replace("Prompt: ", ""),
                    Response = lines[i + 2].Replace("Response: ", "")
                };
                entries.Add(entry);
            }
            Console.WriteLine("Journal loaded from " + filename);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        int randomIndex = new Random().Next(prompts.Count);
                        string randomPrompt = prompts[randomIndex];
                        Console.WriteLine(randomPrompt);
                        string userResponse = Console.ReadLine();
                        journal.AddEntry(randomPrompt, userResponse);
                        break;
                    case 2:
                        Console.WriteLine("User Journal Entries:");
                        journal.DisplayJournal();
                        break;
                    case 3:
                        Console.Write("Please enter the filename to save the journal: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveJournalToFile(saveFilename);
                        break;
                    case 4:
                        Console.Write("Please enter the filename to load the journal: ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadJournalFromFile(loadFilename);
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    private static List<string> prompts = new List<string>
    {
        "How are you feeling today?",
        "What do you want to do better today?",
        "What can you do differently today?",
        "What was the best part of your day today?",
        "What can you ask Heavenly Father to help you with?"
    };
}

