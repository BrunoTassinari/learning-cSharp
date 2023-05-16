using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("loops");
        Console.WriteLine();

        Console.WriteLine("while");
        int monthWhile = 1;

        while (monthWhile <= 12)
        {
            Console.WriteLine(monthWhile);
            monthWhile++;
        }

        Console.WriteLine();
        Console.WriteLine("for");
       
        for (int lines = 0; lines < 10; lines++)
        {
            for (int columns = 0; columns < 10; columns++)
            {
                Console.Write("*");
                if (columns >= lines)
                    break;
                
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Press enter to exit...");
        Console.ReadLine();
    }
}