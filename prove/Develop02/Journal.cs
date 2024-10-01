public class Journal
{
    
    public List<Entry> _entries;
    public static Random random = new Random();
    public static List<string> _prompts = [
        "how was youre day?",
        "who did you talk to?",
        "what things you are grateful today?",
        "what place your visit today",
        "what is the hardest thing your acomplish today?",
    ];

    public static string GeneratePrompt()
    {
        int randomPromptIndex = random.Next(_prompts.Count);
        return _prompts[randomPromptIndex];
    }

    public void CreateEntry()
    {
        string prompt = GeneratePrompt();
        Console.WriteLine(prompt);
        string content = Console.ReadLine();
        Console.WriteLine("When?");
        string date = Console.ReadLine();
        Entry entry = new Entry();
        entry._date = date;
        entry._entryText = content;
        entry._promptText = prompt;
        _entries.Add(entry);
    }

    public void Save()
    {
        string filePath = "journal.txt";

        if (IsEmpty()){
            Console.WriteLine("You have no entries to save!");
            return;
        }

        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            
            foreach (Entry item in _entries)
            {
                string line = $"{item._date},{item._entryText},{item._promptText}";
                writer.WriteLine(line);
            }
        }
    }

    public void Load()
    {
        string filePath = "journal.txt";
        if(File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] rawEntry = line.Split(",");
                Entry newEntry = new Entry();
                newEntry._date = rawEntry[0];
                newEntry._entryText = rawEntry[1];
                newEntry._promptText = rawEntry[2];
                _entries.Add(newEntry);
            }
        }
    }

    public void Display()
    {
        if (IsEmpty()){
            Console.WriteLine("You have no entries to display!");
            return;
        }
        Console.WriteLine("entries");
        foreach (var item in _entries)
        {
            item.Display();
        }
    }

    public bool IsEmpty()
    {
        return _entries.Count == 0;
    }
    
}