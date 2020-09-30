using System;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceInWonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Search for a term in the first sentence of Alice's Adventures in Wonderland:");
            string input = Console.ReadLine();
            int result = aliceInWonderland.ToLower().IndexOf(input.ToLower());

            //Console.WriteLine(result >= 0);

            if (result >= 0)
            {
                Console.WriteLine("Index of term: " + result);
                Console.WriteLine("Length of term: " + input.Length);

                Console.WriteLine("Your search term: " + aliceInWonderland.Substring(result, input.Length));
                Console.WriteLine("Sentence without search term: " + aliceInWonderland.Remove(result, input.Length));
                //
            }
            else
            {
                Console.WriteLine("Term was NOT found.");
            }
        }
    }
}