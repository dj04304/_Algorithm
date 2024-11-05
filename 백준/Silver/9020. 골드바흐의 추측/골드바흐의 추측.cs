using System;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();

        for(int i = 0; i < T; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        foreach(int num in list)
        {
            bool[] isPrime = new bool[num + 1];
            int target = num;

            for (int i = 2; i <= num; i++)
            {
                isPrime[i] = true;
            }

            for(int i = 2; i * i <= num; i++)
            {
                if (isPrime[i])
                {
                    for(int j = i * i; j <= num; j+=i)
                    {
                        isPrime[j] = false; 
                    }
                }
            }

            // 골드바흐 파티션 (최소)
            int a = 0; int b = 0;
            for(int i = num / 2; i >= 2; i--)
            {
                if (isPrime[i] && isPrime[num - i])
                {
                    a = i;
                    b = num - i;
                    break;
                }
            }

            Console.WriteLine($"{a} {b}");

        }


    }
}
