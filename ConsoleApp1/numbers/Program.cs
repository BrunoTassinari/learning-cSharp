using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("int variables");

        int age;
        age = 25;
        Console.WriteLine("The age is " + age);

        age = 30 + 2;
        Console.WriteLine("The age is " + age);

        age = (7 * 5) + 2;
        Console.WriteLine("The age is " + age); 

        age = (2-1) * 10;
        Console.WriteLine("The age is " + age);

        Console.WriteLine();
        Console.WriteLine("double variables");

        double price;
        price = 1.99;
        Console.WriteLine("The price is " + price);

        price = 1.99 * 2;
        Console.WriteLine("The price is " + price);

        price = 3000.10000;
        //double prints 3000.1, not 3000.10000
        Console.WriteLine("The price is " + price);

        price = 7 / 5;
        //double prints 1, not 1.4
        Console.WriteLine("The price is " + price);

        price = 7.0 / 5;
        //double prints 1.4
        Console.WriteLine("The price is " + price);

        price = (double)7 / 5;
        //double prints 1.4
        Console.WriteLine("The price is " + price);

        Console.WriteLine();
        Console.WriteLine("other numeric values");

        long bigNumber;
        bigNumber = 1000000000000000000;
        Console.WriteLine("The big number is " + bigNumber);

        short smallNumber;
        smallNumber = 10000;
        Console.WriteLine("The small number is " + smallNumber);

        float precisionNumber;
        precisionNumber = 1.2345006f;
        //float keeps 7 digits of precision
        Console.WriteLine("The precision number is " + precisionNumber);


        Console.WriteLine();
        Console.WriteLine("Press enter to exit...");
        Console.ReadLine();
    }
}
