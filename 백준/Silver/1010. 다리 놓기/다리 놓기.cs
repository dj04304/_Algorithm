using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());


        for(int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            BigInteger a = Factorial(m);
            BigInteger b = Factorial(n);
            BigInteger c = Factorial(m - n);

            BigInteger result = Factorial(m) / (Factorial(n) * Factorial(m - n));
            Console.WriteLine(result);
        }

    }

    static BigInteger Factorial(int num)
    {
        if (num == 0 || num == 1)
            return 1;

        BigInteger fac = 1;

        for (int i = 2; i <= num; i++)
            fac *= i;

        return fac;
    }

}
