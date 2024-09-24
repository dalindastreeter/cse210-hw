using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Random random = new Random();
        // int guessNumber = random.Next(1, 11);
        {
            Console.Write("Enter the guess number: ");
            int guessNumber = int.Parse(Console.ReadLine()); 
            
            int userGuess=0;
            
            while (userGuess != guessNumber)
            {  
                Console.Write("Enter your guess: ");    
                userGuess= int.Parse(Console.ReadLine()); 
                
                if (userGuess < guessNumber)
                {
                    Console.WriteLine("Higher"); 
                }
                else if (userGuess > guessNumber)
                {
                    Console.WriteLine("Lower"); 
                }
                else
                {
                    Console.WriteLine("You got it! "); 
                }
            }
        }
    }     
}

    

    
    // Console.WriteLine("Guess the guessNumber (between 1 and 11: ");
        //  Console.Write($"what is the guessNumber {guessNumber}? ");
    // Console.Write("What is your guess");

    
// Add a loop that keeps looping as long as the guess does not match the magic number.
// At this point, the user should be able to keep playing until they get the correct answer.
// The following shows the expected output at this point:


//   What is the magic number? 18
//   What is your guess? 5
//   Higher
//   What is your guess? 6
//   Higher
//   What is your guess? 7
//   Higher
//   What is your guess? 20
//   Lower
//   What is your guess? 19
//   Lower
//   What is your guess? 18
//   You guessed it!
  
// Instead of having the user supply the magic number, generate a random number from 1 to 100.
// Play the game and make sure it works!
// Stretch Challenge

// Keep track of how many guesses the user has made and inform them of it at the end of the game.
// After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
// Write and Test the program

// Write and test the program as described above.
// You should complete the 3 Core Requirements.
