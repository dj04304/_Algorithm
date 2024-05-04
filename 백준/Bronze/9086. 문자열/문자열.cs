    internal class Program
    {
        static void Main(string[] args)
        {
            string? ex = Console.ReadLine();
            string? word1 = Console.ReadLine();
            string? word2 = Console.ReadLine();
            string? word3 = Console.ReadLine();

            Console.WriteLine($"{word1[0]}{word1[word1.Length-1]}");
            Console.WriteLine($"{word2[0]}{word2[word2.Length - 1]}");
            Console.WriteLine($"{word3[0]}{word3[word3.Length - 1]}");

        }

    }