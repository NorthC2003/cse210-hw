using System;
using System.Collections.Generic;
using System.Linq;

// Stretch Features Implemented:
// - Only hides words that are not already hidden
// - Can be extended to load scriptures from a file or library

class Program
{
    static void Main(string[] args)
    {
        // You can swap this out to load a random scripture from a list or file (stretch goal)
        var reference = new Reference("Book of Mormon", 1, 5, 6);
        var scriptureText = "For behold, it came to pass that the Lord spake unto my father, yea, even in a dream, and said unto him: Blessed art thou Lehi.";
        var scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") break;

            if (!scripture.AllWordsHidden())
            {
                scripture.HideRandomWords(3); // You can change 3 to hide more/less words
            }
            else
            {
                break; // All words hidden, end the loop
            }
        }

        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nAll words are now hidden. Program ended.");
    }
}
