using System;

class Program
{
    static void Main()
    {
       int n = int.Parse(Console.ReadLine());

       int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        long result = Calculate(n, x);

        Console.WriteLine(result);
    }

    private static long Calculate(int n, int[] x)
    {
        long sum = 0;
        long sum2 = 0;

        for(int i = 0; i < n; i++)
        {
            sum += x[i]; // 배열의 합
            sum2 += (long)x[i] * x[i]; // 배열의 각 요소를 제곱
        }


        return (sum * sum - sum2) / 2;
    }
}