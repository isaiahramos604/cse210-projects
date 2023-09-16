using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Grade ");
        string valuefromUser = Console.ReadLine();

        int x = int.Parse(valuefromUser);

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        int F = 59;

        if (x >=A)
        {
            Console.WriteLine("You have an A");
        }
        else if (A >= x && x >= B)
        {
            Console.WriteLine("You have a B");
            
        }
        else if (B>= x && x>= C)
        {
            Console.WriteLine ("You have a C");
        }
        else if (C>= x && x>= D)
        {
            Console.WriteLine("You have a D");
        }
        else if (F>= x)
        {
            Console.WriteLine("You have an F");
        }
        
        if (x > F)
        {
            Console.WriteLine("Good Job Passing!");

        }
        else
        {
            Console.WriteLine("You got this next time!");
        }
    

        
    }
}