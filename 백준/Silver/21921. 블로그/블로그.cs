using System;

class Program
{
    static void Main(string[] args)
    {
        string[] arrays = Console.ReadLine().Split();

        int n = int.Parse(arrays[0]);
        int x = int.Parse(arrays[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int currentSum = 0;

        for (int i = 0; i < x; i++)
        {
            currentSum += a[i];
        }

        int max = currentSum;
        int count = 1;

        for (int i = x; i < n; i++)
        {
            currentSum = currentSum - a[i - x] + a[i];

            if (currentSum > max)
            {
                max = currentSum;
                count = 1;
            }

            else if (currentSum == max)
            {
                count++;
            }
        }


        if (max == 0)
        {
            Console.WriteLine("SAD");
        }
        else
        {
            Console.WriteLine(max);
            Console.WriteLine(count);
        }

    }

    
}
