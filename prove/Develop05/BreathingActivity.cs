public class BreathingActivity : Activity
{
    public BreathingActivity(string name) 
        : base(name, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") 
    { }

    public void StartActivity()
    {
        GetActivityName();
        int duration = GetDuration();
        int totalElapsed = 0;

        Console.Clear();

        while (totalElapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            totalElapsed += 3;
            if (totalElapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
            totalElapsed += 4;
        }

        EndActivity();
    }
}