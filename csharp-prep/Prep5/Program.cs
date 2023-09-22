using System;

class Program
{
    static void Main(string[] args)
    {
    
            DisplayWelcomeMessage();

            string prompt = username();
            int userNumber = favoriteNum();
            int math = squared(userNumber);
            Display(prompt, math);

    }

            



        
         static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string username()
        {
            Console.Write("Whats is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int favoriteNum()
        {
            Console.Write("Whats is your favorite number? ");
            int favorite = int.Parse(Console.ReadLine());
            return favorite;
        }

        static int squared(int favorite)
        {
            int square = favorite * favorite;
            return square;
            
        }

        static void Display(string name, int square)
        {
            Console.WriteLine($"{name}, the square to your number is {square}.");
        }

    



    
}