using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");

            int[] singleLine = new int[6] { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < singleLine.Length; i++)
            {
                Console.WriteLine(singleLine[i]);
            }

            Console.WriteLine("And now for something completely different!");

            foreach (int i in singleLine)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
