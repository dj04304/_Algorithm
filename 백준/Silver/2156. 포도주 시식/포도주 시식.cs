using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // 입력
        int n = int.Parse(Console.ReadLine());

        int[] wine = new int[n + 1];

        for(int i = 1; i <= n; i++)
        {
            wine[i] = int.Parse(Console.ReadLine());
        }

        int[] dp = new int[n + 1];
        if(n == 1)
        {
            Console.WriteLine(wine[1]);
            return;
        }
        
        if(n == 2)
        {
            Console.WriteLine(wine[1] + wine[2]);
            return;
        }
        
        dp[1] = wine[1];
        dp[2] = wine[1] + wine[2];

        for(int i = 3; i <= n; i++)
        {
            dp[i] = Math.Max(dp[i - 1], Math.Max(dp[i - 2] + wine[i], dp[i - 3] + wine[i] + wine[i - 1]));
        }

        Console.WriteLine(dp[n]);
    }
}
