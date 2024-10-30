using System;

class Program
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        int a = 0;

       List<int> list = new List<int>();
        list = Prime(M, N);

        if(list.Count > 0)
        {
            int sum = 0;

            foreach (int prime in list)
            {
                sum += prime;
            }
            Console.WriteLine(sum);
            Console.WriteLine(list[0]);
        }
        else
        {
            Console.WriteLine(-1);
        }

    }

    static List<int> Prime(int M, int N)
    {
        bool[] isPrime = new bool[N + 1];
        for (int i = 2; i <= N; i++)
        {
            isPrime[i] = true;
        }

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

        List<int> primes = new List<int>();

        for (int i = M; i <= N; i++)
        {
            if (isPrime[i])
                primes.Add(i);
        }

        return primes;
    }
         
}
