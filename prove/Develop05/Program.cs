using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflecting Activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select choice from menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                Console.Clear();
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }

            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                Console.Clear();
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }

            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                Console.Clear();
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            
            else if ( choice == "4")
            {
                Console.WriteLine("Exiting program. Have a great day!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                Thread.Sleep(1000);
                continue;
            }
            Thread.Sleep(1000);
        }
        
    }

    
    
}

