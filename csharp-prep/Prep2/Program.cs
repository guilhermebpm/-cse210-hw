using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercentage);

        string letter;

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("It wasn't this time.");
        }

    }
}