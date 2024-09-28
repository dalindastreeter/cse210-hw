public class Resume
{
    public string _name;
    public List<Job> _jobs;
    public Resume()
    {}

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var item in _jobs)
        {
            item.Display();
        }
    }
    
}