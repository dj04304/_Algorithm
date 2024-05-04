using System;

namespace CodeKata8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCaseCount = int.Parse(Console.ReadLine());

            for (int t = 0; t < testCaseCount; t++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int count = int.Parse(inputs[0]);
                string input = inputs[1];

                if (input != null)
                {
                    char[] chars = input.ToCharArray();

                    foreach (char c in chars)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            Console.Write(c);
                        }
                    }
                    Console.WriteLine(); // Add a new line after printing each P
                }
            }
        }
    }
}
