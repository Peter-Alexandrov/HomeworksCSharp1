﻿using System;

class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter fifth number: ");
        double e = double.Parse(Console.ReadLine());

        double biggestNumber = a;
        if (biggestNumber < b)
        {
            biggestNumber = b;
        }
        if (biggestNumber < c)
        {
            biggestNumber = c;
        }
        if (biggestNumber < d)
        {
            biggestNumber = d;
        }
        if (biggestNumber < e)
        {
            biggestNumber = e;
        }
        Console.WriteLine(biggestNumber);
    }
}

