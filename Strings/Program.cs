using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("alice");

            Console.WriteLine("Enter a word to lookup?");

            string wordToLookUp = Console.ReadLine();

            int index = alice.ToLower().IndexOf(wordToLookUp.ToLower());

            Console.WriteLine($"The word `{wordToLookUp}` can be found at index {index}.");
            Console.WriteLine($"The word is {wordToLookUp.Length} characters long.");

            string newAlice = alice.Remove(index, wordToLookUp.Length);
            Console.WriteLine(newAlice);
        }
    }
}
