using System;

class Program
{
    static void Main(string[] args)
    {
        // ask user grade percentage
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grados = int.Parse(userInput);
        // determinar  letter grade
        string gradoDeLetra;
        if (grados >= 90)
        {
          gradoDeLetra = "A";
        }
        else if (grados >= 80)
        { 
            gradoDeLetra = "B";
        }
        else if (grados >= 70)
        {
            gradoDeLetra = "C";
        }
        else if (grados >= 60)
        {
            gradoDeLetra = "D";
        }
        else 
        {
            gradoDeLetra = "F" ;
        }

    Console.WriteLine($"You got a {gradoDeLetra}");

        if (grados >=70)
        {
            Console.WriteLine("Congratulations you Passed the Class!");
        }

        else{
            Console.WriteLine ("Sorry, keep working");
        }

    }
}