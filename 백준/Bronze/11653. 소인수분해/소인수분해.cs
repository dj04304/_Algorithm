using System;

class Program
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());

        if (M == 1) return;

        // i * i를 하는 이유는 i를 할 경우 불필요한 수 (4, 6, 8... 을 다시한번 반복하여 검사하기 때문에 문제가 생긴다.)
        for(int i = 2; i * i <= M; i++)
        {
            while(M % i == 0)
            {
                Console.WriteLine(i);
                M /= i;
            }
        }

        if (M > 1)
        {
            Console.WriteLine(M);
        }

    }
         
}
