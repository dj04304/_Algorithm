using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int N = input[0];
        int K = input[1];

        int[] items = new int[N];

        for(int i = 0; i < N; i++)
        {
            items[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(items);

        int money = K;
        int total = 0;

        for(int i = 0; i < N; i++)
        {
            if (items[i] > money)
                continue;
            else
            {
                while (money >= items[i])
                {
                    money -= items[i];
                    total++;
                }

            }

            if (money == 0)
                break;

        }

        Console.WriteLine(total);
    }

    
}
