using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        // dp[i] 는 i 개의 돌이 있을 때, 첫 번째 플레이어가 이길 수 있는지 여부
        bool[] dp = new bool[N + 1];
        
        // 초기 조건 설정
        if (N >= 1) dp[1] = true; // SK 승
        if (N >= 2) dp[2] = false; // CY 승
        if (N >= 3) dp[3] = true; // SK 승
        if (N >= 4) dp[4] = false; // CY 승
        
        // 다이나믹 프로그래밍을 이용한 상태 전이
        for (int i = 5; i <= N; i++)
        {
            dp[i] = !dp[i - 1] || !dp[i - 3];
        }
        
        // 결과 출력
        if (dp[N])
        {
            Console.WriteLine("SK");
        }
        else
        {
            Console.WriteLine("CY");
        }
    }
}
