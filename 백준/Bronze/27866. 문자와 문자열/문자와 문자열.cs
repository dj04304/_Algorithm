    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();

            int a = int.Parse(input);

            Console.WriteLine(word[a - 1]);

        }

    }