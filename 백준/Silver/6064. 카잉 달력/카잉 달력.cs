using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        int[] results = new int[T];

        for (int i = 0; i < T; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int M = arr[0];
            int N = arr[1];
            int x = arr[2];
            int y = arr[3];

            results[i] = Calculate(M, N, x, y);
        }

        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
    }

    static int Calculate(int M, int N, int x, int y)
    {
        int lcm = LCM(M, N); // 최소공배수 계산
        int currentX = x;

        while (currentX <= lcm)
        {
            if ((currentX - 1) % N + 1 == y) // y값과 일치 확인
            {
                return currentX;
            }
            currentX += M; // x값을 기준으로 반복
        }

        return -1; // 유효하지 않은 경우
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return a / GCD(a, b) * b;
    }
}
