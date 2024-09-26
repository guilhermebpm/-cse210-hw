using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);

        if (userNumber != 0)
        {
            numbers.Add(userNumber);
        }

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = numbers.Average();

        int largestNumber = numbers.Max();

        int smallestPositiveNumber = numbers.Where(n => n > 0).Min();
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}