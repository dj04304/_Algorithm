using System;

class Program
{
    static void Main(string[] args)
    {
        //string[] arrays = Console.ReadLine().Split();

        //int n = int.Parse(arrays[0]);
        //int k = int.Parse(arrays[1]);

        string input = Console.ReadLine();

        int n = int.Parse(input);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int totalCount = 0;

        for(int i = 0; i < n; i++)
        {
            if (IsTrue(a[i]))
            {
                totalCount++;
            }
        }

        Console.WriteLine(totalCount);
    }

    static bool IsTrue(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;   

        for(int i = 3; i <= Math.Sqrt(num); i +=2 )
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
