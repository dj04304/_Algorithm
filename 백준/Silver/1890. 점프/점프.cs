using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // 입력
        int n = int.Parse(Console.ReadLine());

        int[,] board = new int[n, n];
        long[,] dp = new long[n, n];

        for (int i = 0; i < n; i++)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int j = 0; j < n; j++)
            {
                board[i, j] = nums[j];
            }
        }


        dp[0, 0] = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (dp[i, j] > 0 && board[i, j] != 0)
                {
                    int a = board[i, j];
                    if (i + a < n)
                    {
                        dp[i + a, j] += dp[i, j];
                    }
                    if (j + a < n)
                    {
                        dp[i, j + a] += dp[i, j];
                    }
                }
            }
        }



        Console.WriteLine(dp[n - 1, n - 1]);
    }
}
