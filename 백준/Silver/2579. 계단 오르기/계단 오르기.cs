using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // 계단의 개수
        int[] scores = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            scores[i] = int.Parse(Console.ReadLine());
        }

        // dp[i]는 i번째 계단까지의 최대 점수
        int[] dp = new int[n + 1];
        
        if (n == 1)
        {
            Console.WriteLine(scores[1]);
            return;
        }
        if (n == 2)
        {
            Console.WriteLine(scores[1] + scores[2]);
            return;
        }

        // 초기값 설정
        dp[1] = scores[1];
        dp[2] = scores[1] + scores[2];
        dp[3] = Math.Max(scores[1] + scores[3], scores[2] + scores[3]);

        // 동적 프로그래밍으로 최대 점수 계산
        for (int i = 4; i <= n; i++)
        {
            dp[i] = Math.Max(dp[i - 2] + scores[i], dp[i - 3] + scores[i - 1] + scores[i]);
        }

        // 결과 출력 (마지막 계단은 반드시 밟아야 함)
        Console.WriteLine(dp[n]);
    }
}
