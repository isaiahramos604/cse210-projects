using System;

public class Scriptures
{
    private string script = "Blessed is the man that trusteth in the Lord, and whose hope the Lord is.";

    public string GetScript()
    {
        return script;
    }

    public void SetScript(string newScript)
    {
        script = newScript;
    }
}

public class Refrence
{
    private string refer = "Jeremiah 17:7";

    public string GetRefer()
    {
        return refer;
    }

    public void SetRefer(string newRefer)
    {
        refer = newRefer;
    }
}

class Program
{
    static Random random = new Random();

    static void Game(Scriptures scriptures, Refrence reference)
    {
        Console.WriteLine($"{reference.GetRefer()} : {scriptures.GetScript()}");
        Console.WriteLine("Press Enter to Replace multiple words with '_' or type quit to exit: ");
        string valueFromUser = Console.ReadLine();

        if (valueFromUser.ToLower() == "quit")
            return;

        else if (scriptures.GetScript().Replace("_", "").Trim() == "")
            return;

        scriptures.SetScript(ReplaceRandomly(scriptures.GetScript()));
        Console.Clear();
        Game(scriptures, reference);
    }

    static string ReplaceRandomly(string script)
    {
        string[] words = script.Split(' ');

        // Determine how many words to replace (you can change this number)
        int numWordsToReplace = random.Next(1, 3);

        for (int i = 0; i < numWordsToReplace; i++)
        {
            int randomIndex = random.Next(0, words.Length);
            words[randomIndex] = new string('_', words[randomIndex].Length);
        }

        return string.Join(" ", words);
    }

    static void Main(string[] args)
    {
        Scriptures scriptures = new Scriptures();
        Refrence reference = new Refrence();

        Game(scriptures, reference);
    }
}
