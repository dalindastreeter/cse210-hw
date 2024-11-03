

public class Activity  
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage() 
    {
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine(_description);
        
        Console.Write("How long, in seconds, would like for your session? ");
        string input = Console.ReadLine();
        if (input != null && input != "")
        {
            _duration = int.Parse(input);
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine("Activity done. Great work!");
        
    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void DisplayPrep()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    
    protected void ShowSpinner(int seconds)
    {
        List<string> frames = new List<string>();
        frames.Add("\\");
        frames.Add("|");
        frames.Add("/");
        frames.Add("–");
        int targetDurationMilliseconds = seconds * 1000;
        int durationMilliseconds = 0;
        int sleepMilliseconds = 200;
        while (targetDurationMilliseconds > durationMilliseconds) {
            foreach (var f in frames)
            {
                Console.Write(f);
                Thread.Sleep(sleepMilliseconds);
                Console.Write("\b \b");
                durationMilliseconds += sleepMilliseconds;
            }
        }
    }
}


