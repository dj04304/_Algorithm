using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Queue<char> queue = new Queue<char>();

            foreach (char c in word)
            {
                queue.Enqueue(c);
            }

            bool isTrue = true;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                char c = queue.Dequeue();
                if (c != word[i])
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }

    }
}
