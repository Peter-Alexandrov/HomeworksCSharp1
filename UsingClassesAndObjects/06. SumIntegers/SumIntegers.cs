﻿//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//  Example:      input 	            output
//           "43 68 9 23 318" 	         461         

using System;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by \'space\'");
        Console.WriteLine("Than hit enter to see their result");
        string[] input = Console.ReadLine().Split(' ');
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum = sum + int.Parse(input[i].Trim());
        }
        Console.WriteLine("Result--->"+sum);
    }
}
