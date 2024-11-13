using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        long n = long.Parse(input[0]);
        long m = long.Parse(input[1]);

        long countTwo = Calculate(n ,2) - Calculate(m ,2) - Calculate(n - m , 2);
        long countFive = Calculate(n, 5) - Calculate(m, 5) - Calculate(n - m, 5);

        Console.WriteLine(Math.Min(countTwo, countFive));
    }

    static long Calculate(long n, long num)
    {

        long count = 0;

        while(n >= num)
        {
            count += n / num;
            n /= num;
        }


        return count;
    }

}
