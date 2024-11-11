using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        List<int> primes = Prime(N);

        int count = TwoPointers(N, primes);

        Console.WriteLine(count);
    }

    static List<int> Prime(int N)
    {
        bool[] isPrime = new bool[N + 1];
        List<int> primes = new List<int>();

        for(int i = 2; i <= N; i++)
            isPrime[i] = true;

        for (int i = 2; i * i <= N; i ++)
        {
            if (isPrime[i])
            {
                for(int j = i * i; j <= N; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        for(int i = 2; i <= N; i ++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }
        
        return primes;
    }

    static int TwoPointers(int N, List<int> primes)
    {
        int start = 0;
        int sum = 0;
        int count = 0;

        for(int end = 0; end < primes.Count; end ++)
        {
            sum += primes[end];

            while(sum > N && start <= end)
            {
                sum -= primes[start];
                start++;
            }

            if (sum == N)
                count++;

        }

        return count;

    }
}
