﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("char variables");

        char letter;
        letter = 'a';
        Console.WriteLine("The letter is " + letter);

        letter = (char)(letter + 1);
        // char prints b, not 98 ASCII
        Console.WriteLine("The letter is " + letter);

        letter++;
        // char prints c, not 99 ASCII
        Console.WriteLine("The letter is " + letter);


        Console.WriteLine();
        Console.WriteLine("string variables");

        string name;
        name = "Bruno";

        string lastName;
        lastName = "Tassinari";

        string fullName;
        fullName = name + " " + lastName;

        Console.WriteLine("My name is " + fullName);


        Console.WriteLine();
        Console.WriteLine("Press enter to exit...");
        Console.ReadLine();
    }
}
