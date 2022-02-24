using System;
using System.Security.Cryptography;
using VisualLab2;


class Program
{
    public static void Main()
    {
        Console.WriteLine(RomanNumb.Add(new RomanNumb(20), new RomanNumb(10)));
        Console.WriteLine(RomanNumb.Sub(new RomanNumb(20), new RomanNumb(10)));
        Console.WriteLine(RomanNumb.Mul(new RomanNumb(20), new RomanNumb(10)));
        Console.WriteLine(RomanNumb.Div(new RomanNumb(20), new RomanNumb(10)));
        RomanNumb[] RomanNumbArray = new RomanNumb[10];
        for (int i = 0; i < 10; i++)
        {
            RomanNumbArray[i] = new RomanNumb((ushort)(new Random().Next(1, 1000)));
            Console.Write(RomanNumbArray[i] + " ");
        }
        Console.WriteLine();

        Array.Sort(RomanNumbArray);

        for (int i = 0; i < 10; i++)
        {
            Console.Write(RomanNumbArray[i] + " ");
        }
    }
}