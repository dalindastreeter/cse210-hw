using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write ("What is your name? ");
        String nameFirst = Console.ReadLine();
        Console.Write ("What is your last name? ");
        String nameLast = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {nameLast}, {nameLast} {nameFirst}.");
    }
}