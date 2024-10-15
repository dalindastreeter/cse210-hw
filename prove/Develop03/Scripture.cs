public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] rawWords = text.Split(' ');

        foreach (var rawWord in rawWords)
        {
            if (rawWord == "")
            {
                continue;
            }

            _words.Add(new Word(rawWord));
        }
    }

    public void HideRandomWords()
    {
        int found = 0;
        int attempts = 0;
        int maxAttempts = _words.Count;
        while (found != 3 && attempts < maxAttempts)
        {
            Random rnd = new Random();
            int wordIndex = rnd.Next(_words.Count());
            Word word = _words[wordIndex];
            if (!word.IsHidden())
            { 
                word.Hide();
                found += 1;
            }
            attempts += 1;
        }
    }

    public string GetDisplayReference()
    {
        return _reference.GetDisplayText();
    }
    
    public string GetDisplayText()
    {
        string text = "";
        foreach (var word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text;
        
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    

}