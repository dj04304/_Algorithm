using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] dp = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            dp[i] = int.MaxValue;
        }
        dp[0] = 0;
        
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k * k <= i; k++)
            {
                dp[i] = Math.Min(dp[i], dp[i - k * k] + 1);
            }
        }
        
        Console.WriteLine(dp[n]);
    }
}
