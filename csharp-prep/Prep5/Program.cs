

class Program

{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int num= PromptUserNumber();
        int square = SquareNumber(num);
    

        Console.WriteLine($"{name}, the square of your number is {square}");
        // DisplayResult();
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");

    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int  PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int n = int.Parse(number);
        return n;
    }
    
     static int SquareNumber(int number)
    {
        return  number * number;
    }
     static void DisplayResult(string name, int square)
    {
      Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}
    

    

    



// DisplayWelcome - Displays the message, "Welcome to the Program!"
// PromptUserName - Asks for and returns the user's name (as a string)
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name and the squared number and displays them.
// Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

// Sample output of the program could look as follows:


// Welcome to the program!
// Please enter your name: Brother Burton
// Please enter your favorite number: 42
// Brother Burton, the square of your number is 1764
// Write and Test the program

// Write and test the program as described above.
// Make sure to use the same project template that you did for the previous activities. However, this time, you should add your code in Program.cs file in the the Prep 5 project.
