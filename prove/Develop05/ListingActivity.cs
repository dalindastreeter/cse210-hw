namespace Develop05;

    public class ListingActivity : Activity
    {
        private List<string> _prompts;

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n", 30)
        {
            _prompts = new List<string>();
            _prompts.Add("Best thing the happen today?");
            _prompts.Add("Que cosa buena hiciste today ?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Que te hizo reir hoy?");
        }

        public void Run()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
           

            Console.WriteLine("List as many responses you can to the following prompt");
            Console.WriteLine($"\n--{prompt}---");
            Console.Write("You may begin in:");
            ShowCountDown(5);
            List<string> answers = new List<string>();
         
     
            
            while (DateTime.Now < endTime)
            {
                Console.Write("\n");
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    break;
                }
                answers.Add(input);
            }
            
            Console.WriteLine($"\nYou listed {answers.Count} items:");
        
        }
}
