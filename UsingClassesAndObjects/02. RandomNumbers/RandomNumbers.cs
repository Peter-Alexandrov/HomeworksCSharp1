﻿//Problem 2. Random numbers
//
//Write a program that generates and prints to the console 10 random values  
//in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine((i + 1) + ": " + rand.Next(100, 201));
        }
    }
}
