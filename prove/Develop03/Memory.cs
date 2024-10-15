public class Memory
{
    private List<Scripture> _scriptures;

    public Memory()
    {
        _scriptures = new List<Scripture>();
    }

    public void LoadScriptures()
    {
        string filePath = "memory.txt";
        if(File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] rawMemory = line.Split("|");
                string bookReference = rawMemory[0];
                string rawChapterReference = rawMemory[1];
                int chapterReference = int.Parse(rawChapterReference);
                string rawVerseReference = rawMemory[2];
                int verseReference = int.Parse(rawVerseReference);
                string rawEndVerseReference = rawMemory[3];
                int endVerseReference = int.Parse(rawEndVerseReference);
                Reference loadedRef = new Reference(bookReference, chapterReference, verseReference, endVerseReference);
                string rawScripture = rawMemory[4];
                if (rawScripture.Length == 0)
                {
                    Console.WriteLine("Error: Scripture text is empty.");
                    continue;
                }
                
                string[]rawWords = rawScripture.Split("$");
                string loadedText = "";
                foreach (string rawWord in rawWords)
                {
                    loadedText += rawWord + " ";
                }
                Scripture newScripture = new Scripture(loadedRef, loadedText);
                _scriptures.Add(newScripture);
            }
        }
    }

    public void SaveScriptures()
    {
        string filePath = "memory.txt";

        if (IsEmpty())
        {
            Console.WriteLine("You have no scriptures to save, nothing to save.");
            return;
        }
        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Scripture scripture in _scriptures)
            {
                Reference r = scripture.GetReference();
                List<Word> wrds = scripture.GetWords();
                string wrdsCombined = "";
                foreach (Word wrd in wrds)
                {
                    wrdsCombined += wrd.GetText() + " ";
                }
                string refCombined = $"{r.GetBook()}|{r.GetChapter()}|{r.GetVerse()}|{r.GetEndVerse()}";
                string scriptureCombined = $"{refCombined}|{wrdsCombined}";
                writer.WriteLine(scriptureCombined);
            }
        }
    }

    public void ShowScriptures()
    {
        int scriptureIndex = 0;
        foreach (var scripture in GetScriptures())
        {
            Console.WriteLine(scripture.GetDisplayReference() + $"({scriptureIndex})");
            scriptureIndex += 1;
        }
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public List<Scripture> GetScriptures()
    {
        return _scriptures;
    }

    public void LearnScripture(int scriptureIndex)
    {
        Scripture scripture = _scriptures[scriptureIndex];
        while(true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayReference() + " " + scripture.GetDisplayText());
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string selection = Console.ReadLine();
            if (selection == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            scripture.HideRandomWords();
        }
        List<Word> words = scripture.GetWords();
        foreach (Word word in words)
        {
            word.Show();
        }
    }
    
    public bool IsEmpty()
    {
        return _scriptures.Count == 0;
    }
}