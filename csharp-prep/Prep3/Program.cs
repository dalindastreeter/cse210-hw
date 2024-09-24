

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int guessNumber = random.Next(1, 100);
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

    

// Keep track of how many guesses the user has made and inform them of it at the end of the game.
// After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
// Write and Test the program

// Write and test the program as described above.
// You should complete the 3 Core Requirements.
