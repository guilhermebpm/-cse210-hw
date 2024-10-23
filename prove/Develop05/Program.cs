using System;

class Program
{
    static void Main(string[] args)
    {
        int activityCount = 0;
        bool isRunning = true;  // Variável para controlar o loop do menu

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start listing activity");
            Console.WriteLine("   3. Start reflecting activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity("Breathing");
                    breathing.StartActivity();
                    activityCount++;
                    break;
                case 2:
                    ListingActivity listing = new ListingActivity("Listing");
                    listing.StartActivity();
                    activityCount++;
                    break;
                case 3:
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting");
                    reflecting.StartActivity();
                    activityCount++;
                    break;
                case 4:
                    Console.WriteLine("Exiting the program...");
                    Console.WriteLine($"You completed a total of {activityCount} activities.");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            if (isRunning)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();  // Aguarda o usuário pressionar uma tecla antes de voltar ao menu
            }
        }
    }
}