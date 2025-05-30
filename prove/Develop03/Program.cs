// Program.cs
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("Proverbs", 3, 5, 6,
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
            new Scripture("Ether", 12, 27,
        "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."),
            new Scripture("John", 3, 16,
        "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        };

        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            Console.WriteLine("Select a scripture to practice.\n");

            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].GetReference()}");
            }
            Console.WriteLine("Q. Quit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "q")
            {
                keepGoing = false;
            }
            else if (int.TryParse(choice, out int index) && index >= 1 && index <= scriptures.Count)
            {
                Scripture selected = scriptures[index - 1];
                selected = new Scripture(selected.GetReferenceObject(), selected.GetFullText());
                PracticeScripture(selected);
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to try again.");
                Console.ReadLine();
            }
        }

        static void PracticeScripture(Scripture scripture)
        {
            bool allHidden = false;
            while (!allHidden)
            {
                Console.Clear();
                scripture.ShowScripture();

                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit");
                string input = Console.ReadLine();
                

                if (input.ToLower() == "quit")
                {
                    break;
                }

                allHidden = scripture.HideSomeWords();
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                scripture.UnhideWords();
                scripture.ShowScripture();
                Console.WriteLine("\nScripture memorization complete!");
                Console.ReadLine();
            }
            
        }
    }
}