using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromeWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Palindrome Checker");
            Console.WriteLine("----------------------------------");

            bool continueChecking = true;

            while (continueChecking)
            {
                Console.WriteLine("Enter a word you'd like to check:");
                string word = Console.ReadLine();

                if (IsPalindrome(word))
                {
                    Console.WriteLine("The word " + word + " is a palindrome.");
                }
                else
                {
                    Console.WriteLine("The word " + word + " is not a palindrome.");
                }

                Console.WriteLine("Do you want to check another word? (Y/N)");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice != 'Y' && choice != 'y')
                {
                    continueChecking = false;
                }
            }

            Console.WriteLine("Press the spacebar to exit");
            while (Console.ReadKey(true).Key != ConsoleKey.Spacebar) { }
        }

        static bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
