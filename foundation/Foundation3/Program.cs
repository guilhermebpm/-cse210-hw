using System;

public class Program
{
    public static void Main()
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 10, 23), 30, 5.0),
            new Cycling(new DateTime(2024, 10, 23), 45, 20.0),
            new Swimming(new DateTime(2024, 10, 23), 40, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}