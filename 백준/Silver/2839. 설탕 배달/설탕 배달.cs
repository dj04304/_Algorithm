using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(DP(n));

    }

    static int DP(int n)
    {
        int count = 0;
        int result = n;

        while(result >= 0)
        {
            if(result % 5 == 0)
            {
                count += result / 5;

                return count;
            }
            else
            {
                result -= 3;
                count++;
            }

        }

        return -1;

    }


}
