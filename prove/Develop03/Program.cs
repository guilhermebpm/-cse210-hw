using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<(Reference reference, string text)>
        {
            (new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            (new Reference("Helaman", 5, 12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."),
            (new Reference("Alma", 11, 43), "The spirit and the body shall be reunited again in its perfect form."),
            (new Reference("Alma", 36, 3), "Whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day."),
            (new Reference("Alma", 40, 23), "The soul shall be restored to the body, and the body to the soul; yea, and every limb and joint shall be restored to its body; yea, even a hair of the head shall not be lost; but all things shall be restored to their proper and perfect frame."),
            (new Reference("Alma", 42, 8), "Now behold, it was not expedient that man should be reclaimed from this temporal death, for that would destroy the great plan of happiness."),
            (new Reference("Alma", 7, 11), "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people."),
            (new Reference("Alma", 7, 11, 12), "And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities."),
            (new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.")
        };

        Console.WriteLine("Choose a reference:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {scriptures[i].reference.GetDisplayText()}");
        }

        Console.Write("Enter the number of the reference you want: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= scriptures.Count)
        {
            var selectedScripture = scriptures[index - 1];
            Scripture scripture = new Scripture(selectedScripture.reference, selectedScripture.text);

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("All words have been hidden!");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}