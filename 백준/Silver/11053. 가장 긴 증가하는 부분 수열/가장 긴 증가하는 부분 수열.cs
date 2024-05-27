using System;

class Program
{
    static void Main(string[] args)
    {
        // 입력
        int count = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[count];

        for (int i = 0; i < count; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        // 동적 계획법을 이용한 LIS 계산
        int[] dp = new int[count];
        for (int i = 0; i < count; i++)
        {
            dp[i] = 1; // 초기값: 최소 길이는 자기 자신만 포함하는 수열이므로 1
            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        // 결과 출력: dp 배열에서 최대값을 찾음
        int lisLength = 0;
        for (int i = 0; i < count; i++)
        {
            if (dp[i] > lisLength)
            {
                lisLength = dp[i];
            }
        }

        Console.WriteLine(lisLength);
    }
}
