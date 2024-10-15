class Program
{
    static void Main(string[] args)
    {
        Memory memory = new Memory();
        string menuChoice = "";
        do
        {
            Console.WriteLine("Scripture Memorizer Menu");
            Console.WriteLine("----Add scripture (1)");
            Console.WriteLine("----Learn Scripture (2)");
            Console.WriteLine("----Save Scriptures (3)");
            Console.WriteLine("----Load Scriptures (4)");
            Console.WriteLine("----Quit (5)");
            
            menuChoice = Console.ReadLine();
            if (menuChoice == "1")
            {
                Console.WriteLine("Adding Scripture");
                Console.WriteLine("What Book? ");
                string book = Console.ReadLine();
                Console.WriteLine("What Chapter? ");
                string chapterRaw = Console.ReadLine();
                if (chapterRaw == null)
                {
                    Console.WriteLine("Invalid Chapter.");
                    continue;
                }
                int chapter = int.Parse(chapterRaw);
                Console.WriteLine("What Verse(s)? ");
                string verseRaw = Console.ReadLine();
                if (verseRaw == null)
                {
                    Console.WriteLine("Invalid Verse.");
                    continue;
                }

                string[] verses = verseRaw.Split('-');
                int verseStart;
                int verseEnd;
                if (verses.Count() == 2)
                {
                    string rawVerseStart = verses[0];
                    verseStart = int.Parse(rawVerseStart);
                    string rawVerseEnd = verses[1];
                    verseEnd = int.Parse(rawVerseEnd);
                } else if (verses.Count() == 1)
                {
                    string rawVerseStart = verses[0];
                    verseStart = int.Parse(rawVerseStart);
                    verseEnd = verseStart;
                }
                else
                {
                    Console.WriteLine("Invalid Verse.");
                    continue;
                }
                Console.WriteLine("What text? ");
                string text = Console.ReadLine();
                Reference reference = new Reference(
                    book,
                    chapter,
                    verseStart,
                    verseEnd
                );
                Scripture newScripture = new Scripture(reference, text);
                memory.AddScripture(newScripture);
            }
            else if (menuChoice == "2")
            {
                Console.WriteLine("Learning Scripture");
                if (memory.IsEmpty())
                {
                    Console.WriteLine("No scripture available to learn, add some.");
                    continue;
                }
                Console.WriteLine("Press enter to pick random scripture, enter a selection, or type 'back' to return to the menu:");
                memory.ShowScriptures();
                string choiceScripture = Console.ReadLine();
                int choiceScriptureIndex;
                if (String.IsNullOrEmpty(choiceScripture))
                {
                    int availableScriptures = memory.GetScriptures().Count();
                    Random rand = new Random();
                    choiceScriptureIndex = rand.Next(availableScriptures);
                } else if (choiceScripture == "back")
                {
                    continue;
                }
                else
                {
                    choiceScriptureIndex = int.Parse(choiceScripture);
                }
                memory.LearnScripture(choiceScriptureIndex);
            }
            else if (menuChoice == "3")
            {
                Console.WriteLine("Saving Scriptures");
                if (memory.IsEmpty())
                {
                    Console.WriteLine("No scripture(s) available to save, add some.");
                    continue;
                }
                memory.SaveScriptures();
            }
            else if (menuChoice == "4")
            {
                Console.WriteLine("Loading Scriptures");
                memory.LoadScriptures();
            }

        } while (menuChoice != "5");
        Console.WriteLine("Quitting Scripture Memorize.");
    }
}

// I created a memorize menu that give you different option to interact with the program, for example save and load the scriptures.