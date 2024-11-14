using System;

class Program
{
    static void Main()
    {
        // 입력 받기
        long k = long.Parse(Console.ReadLine());
        k--; // 0-based index로 변환

        int ans = 0;

        // 1의 개수를 계산
        while (k > 0)
        {
            ans += (int)(k % 2); // 1의 개수 증가
            k /= 2; // k를 2로 나눔
        }

        // 결과 출력 (1의 개수의 홀짝성)
        Console.WriteLine(ans % 2);
    }
}