using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Guilherme Melo", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Jhon", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

    }
}