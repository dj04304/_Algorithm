using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int M = int.Parse(input[0]);
        int N = int.Parse(input[1]);

        // 에라토스테네스의 체 초기화
        bool[] isPrime = new bool[N + 1];
        for (int i = 2; i <= N; i++)
        {
            isPrime[i] = true;
        }

        // 소수 여부 판별
        for (int i = 2; i * i <= N; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= N; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // M 이상 N 이하의 소수 출력
        for (int i = M; i <= N; i++)
        {
            if (isPrime[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}
