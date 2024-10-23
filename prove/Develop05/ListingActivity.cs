public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt joy recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name) 
        : base(name, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") 
    { }

    public void StartActivity()
    {
        GetActivityName();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        List<string> items = new List<string>();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();
    }
}