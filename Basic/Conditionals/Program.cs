using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("conditionals");
        Console.WriteLine();

        Console.WriteLine("if/else");
        int age = 16;

        if(age >= 18)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are not an adult");
        }

        Console.WriteLine();
        Console.WriteLine("Press enter to exit...");
        Console.ReadLine();
    }
}