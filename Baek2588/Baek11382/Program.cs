
namespace Baek11382
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            long[] result = new long[arr.Length];

            for(int i = 0; i < arr.Length; i++) 
            {
                result[i] = long.Parse(arr[i]);
            }

            long total = 0;
            for(int i = 0; i < arr.Length; i++) 
            {
                total += result[i];
            }

            Console.WriteLine(total);

        }
    }
}