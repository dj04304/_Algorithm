using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[] distances = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] price= Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] distanceArray = new int[N - 1];

        int[] priceArray = new int[N];

        for(int i = 0; i < N - 1; i++)
            distanceArray[i] = distances[i];

        for (int i = 0; i < N; i++)
            priceArray[i] = price[i];


        long total = 0;
        int currentPrice = priceArray[0];

        for(int i = 0; i < N - 1; i++)
        {
            total += distanceArray[i] * (long)currentPrice;

            if (priceArray[i + 1] < currentPrice)
            {
                currentPrice = priceArray[i + 1];
            }

        }

        Console.WriteLine(total);
    }

    
}
