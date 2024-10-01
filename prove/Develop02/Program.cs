class Program
{
    static void Main(string[] args)
    {
        
        

        // Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
        string menuChoice = "";
        Journal journal = new Journal();
        journal._entries = new List<Entry>();
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----Write a new entry (1)");
            Console.WriteLine("----Display the journal (2)");
            Console.WriteLine("----Save the journal to a file (3)");
            Console.WriteLine("----Load the journal from a file (4)");
            Console.WriteLine("----Exit (5)");
            menuChoice = Console.ReadLine();
            if(menuChoice == "1") {
                Console.WriteLine("You chose 1");
                journal.CreateEntry();
            }
            else if(menuChoice == "2") {
                // Display the journal - Iterate through all entries in the journal and display them to the screen.
                Console.WriteLine("You chose 2");
                journal.Display();
            }
            else if(menuChoice == "3") {
                Console.WriteLine("You chose 3");
                journal.Save();
                // Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
            }
            else if(menuChoice == "4") {
                Console.WriteLine("You chose 4");
                journal.Load();
                // Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
            }
        } while (menuChoice != "5");
        Console.WriteLine("Nice to see you again, until later...");
    }
}