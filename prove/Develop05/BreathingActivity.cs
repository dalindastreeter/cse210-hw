namespace Develop05;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity", 
        "This activity will help you to relax by walking through breathing in and out slowly,clear your mind and focus on your breathing.\n", 
        30)
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayPrep();
        Console.WriteLine("\n");
        int elapsed = 0;
        int period = 3;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Console.Write("Now breathe out...");
            ShowCountDown(period);
            Console.WriteLine("\n");
            elapsed += period;
        }
    }
}
    
