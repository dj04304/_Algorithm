using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        // 입력
        int count = int.Parse(Console.ReadLine());

        for(int k = 0; k < count; k++)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] stickers = new int[2, n];

            for(int i = 0; i < 2; i++)
            {
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                for (int j = 0; j < n; j++)
                {
                    stickers[i, j] = nums[j];
                }

            }

            if(n == 1)
            {
                sb.AppendLine(Math.Max(stickers[0,0], stickers[1,0]).ToString());
                continue;
            }


            int[,] dp = new int[2, n];

            // 초기값 설정
            dp[0, 0] = stickers[0, 0];
            dp[1, 0] = stickers[1, 0];
            dp[0, 1] = stickers[1, 0] + stickers[0, 1];
            dp[1, 1] = stickers[0, 0] + stickers[1, 1];

            for(int i = 2; i < n; i++)
            {
                dp[0, i] = Math.Max(dp[1, i - 2], dp[1, i - 1]) + stickers[0, i];
                dp[1, i] = Math.Max(dp[0, i - 2], dp[0, i - 1]) + stickers[1, i];
            }

            int result = Math.Max(dp[0, n - 1], dp[1, n - 1]);

            sb.AppendLine(result.ToString());

        }

        Console.WriteLine(sb);
    }
}
