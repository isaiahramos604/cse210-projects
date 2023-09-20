using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int Magic = randomGenerator.Next(2,200);
        int guess = -1;

       while(guess != Magic)
       {
            Console.WriteLine("What is your guess for the Magic Number?");
            guess = int.Parse(Console.ReadLine());

            if (guess > Magic)
            {
                Console.WriteLine("Lower");

            }
            else if (guess < Magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
           

       }


       
        


        







        

        
    }
}