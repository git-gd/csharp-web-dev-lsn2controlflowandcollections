using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace ListExercises
{
    class Program
    {
        static int MySum(List<int> sumList)
        {
            int total = 0;

            foreach (int i in sumList)
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }

            return total;
        }

        static void PrintWords(List<string> words, int length)
        {
            foreach (string word in words)
            {
                if (word.Length == length)
                {
                    Console.WriteLine(word);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");

            List<int> aList = new List<int> {1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine(MySum(aList));

            List<string> myWords = new List<string> { "happy", "joy", "boat", "dog", "zebra" };

            myWords.Add("Statue");
            myWords.Add("Penguin");
            myWords.Add("OK");
            myWords.Add("okay");

            int userLength = 4;

            PrintWords(myWords, userLength);

            while (userLength > 0)
            {
                Console.WriteLine("Enter the length of the words you wish to search for or 0 to exit.");

                try
                {
                    userLength = int.Parse(Console.ReadLine());
                } 
                catch
                {
                    userLength = 0;
                }

                PrintWords(myWords, userLength);
            }

            // BONUS MISSION: Use the string from Array Practice to create a list
            Console.WriteLine("BONUS MISSION: Using The Sentence From Array Practice!");

            string bonusString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            bonusString = bonusString.Replace(",", "");
            bonusString = bonusString.Replace(".", "");

            myWords = bonusString.Split(' ').ToList();

            do
            {
                Console.WriteLine("Enter the length of the words you wish to search for or 0 to exit.");
                
                try
                {
                    userLength = int.Parse(Console.ReadLine());
                }
                catch
                {
                    userLength = 0;
                }

                PrintWords(myWords, userLength);

            } while (userLength > 0);
        }
    }
}
