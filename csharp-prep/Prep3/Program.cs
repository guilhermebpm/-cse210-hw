using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessOficialNumber = 0;

        while (magicNumber != guessOficialNumber)
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine(); 
            guessOficialNumber = int.Parse(guessNumber);

            if (magicNumber > guessOficialNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessOficialNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}
