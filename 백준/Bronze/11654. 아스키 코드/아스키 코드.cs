    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if(input.Length >= 1)
            {
                char c = Convert.ToChar(input);
                int a = Convert.ToInt32(c);

                Console.WriteLine(a);

            }
        }

    }