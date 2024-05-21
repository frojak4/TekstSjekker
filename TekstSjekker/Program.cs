using System.Security.Cryptography.X509Certificates;

namespace TekstSjekker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                Console.Clear();
                Console.WriteLine("Skriv inn din tekst!");
                string userInput = Console.ReadLine();

                Console.WriteLine($"Palindrom: {Utility.palindrome(userInput)}");
                Console.WriteLine($"Reversed: {Utility.reversed(userInput)}");
                Console.ReadKey(true);

            }
        }
    }
}
