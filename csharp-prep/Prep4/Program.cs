using System;
using System.ComponentModel;

class Program
{

    static void Main(string[] args)
    {
        List<int>numbers=new List<int>();
        int inputNumber;
       
        do
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine()); 
         
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }

        } 
         
        while (inputNumber != 0);  
        int sum = 0;
         
        foreach (int number in numbers)
            {
             sum += number;
            }
        Console.WriteLine("The sum is: " + sum);
    }
}
 

// Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.

// Once you have a list, have your program do the following:

// Core Requirements

// Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

// Compute the sum, or total, of the numbers in the list.
// Compute the average of the numbers in the list.
// Find the maximum, or largest, number in the list.
// The following shows the expected output:


//   Enter a list of numbers, type 0 when finished.
//   Enter number: 18
//   Enter number: 36
//   Enter number: 2
//   Enter number: 48
//   Enter number: 6
//   Enter number: 12
//   Enter number: 9
//   Enter number: 0
//   The sum is: 131
//   The average is: 18.714285714285715
//   The largest number is: 48
  
// 