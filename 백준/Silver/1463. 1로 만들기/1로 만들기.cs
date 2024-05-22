using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] dp = new int[n + 1];

        // Initialize dp array
        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + 1; // Subtract 1 operation

            if (i % 2 == 0)
            {
                dp[i] = Math.Min(dp[i], dp[i / 2] + 1); // Divide by 2 operation
            }

            if (i % 3 == 0)
            {
                dp[i] = Math.Min(dp[i], dp[i / 3] + 1); // Divide by 3 operation
            }
        }

        // Output the result
        Console.WriteLine(dp[n]);
    }
}
