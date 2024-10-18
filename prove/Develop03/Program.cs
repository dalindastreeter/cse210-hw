// additional features added on top of required features
//   main menu for different interactions (load/save/add/learn)
//   load scriptures from a file.
//   Save scripture that we added
//   Add scripture to a list the scripture that we learn
class Program
{
    static void Main(string[] args)
    {
        Memory memory = new Memory();
        string menuChoice = "";
        do
        {
            Console.WriteLine("Scripture Memorizer Menu");
            Console.WriteLine("\tAdd scripture\t\t1");
            Console.WriteLine("\tLearn Scripture\t\t2");
            Console.WriteLine("\tSave Scriptures\t\t3");
            Console.WriteLine("\tLoad Scriptures\t\t4");
            Console.WriteLine("\tExit Program\t\t5");
            
            menuChoice = Console.ReadLine();
            Console.Clear();
            if (menuChoice == "1")
            {
                Console.WriteLine("Adding Scripture");
                Console.Write("What Book(ex: Ruth)? ");
                string book = Console.ReadLine();
                Console.Write("What Chapter(ex: 1)? ");
                string chapterRaw = Console.ReadLine();
                if (chapterRaw == null)
                {
                    Console.WriteLine("Invalid Chapter.");
                    continue;
                }
                int chapter = int.Parse(chapterRaw);
                Console.Write("What Verse(ex: 3 or a range 3-15)? ");
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
                Console.Write("What text? ");
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
        Console.WriteLine("Exiting Scripture Memorize Program.");
    }
}

