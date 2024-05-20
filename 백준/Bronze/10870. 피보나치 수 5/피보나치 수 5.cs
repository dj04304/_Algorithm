using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        
        // 기본 값 처리
        if (a == 0)
        {
            Console.WriteLine(0);
            return;
        }
        if (a == 1)
        {
            Console.WriteLine(1);
            return;
        }

        // 재귀적으로 피보나치 수 계산
        int result = Fibonacci(a);
        Console.WriteLine(result);
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
