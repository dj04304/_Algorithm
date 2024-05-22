using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class Program
{

    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());
        int[] dp = new int[11];

        dp[0] = 1;

        for (int i = 1; i <= dp.Length - 1; i++)
        {
            if (i >= 1)
                dp[i] += dp[i - 1];
            if (i >= 2)
                dp[i] += dp[i - 2];
            if (i >= 3)
                dp[i] += dp[i - 3];
        }

        for (int i = 0; i < count; i++)
        {
            int n = int.Parse(Console.ReadLine());

            sb.AppendLine(dp[n].ToString());
        }

        Console.WriteLine(sb);

    }

}
