using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        List<int> divisor = new List<int>();

        list = Inputs();

        foreach (int num in list)
        {
            divisor = Divisor(num);

            if(divisor.Sum() == num)
            {
                string result = $"{num} = {string.Join(" + ", divisor)}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"{num} is NOT perfect.");
            }
        }


    }

    static List<int> Inputs()
    {
        List<int> list = new List<int>();

        while (true)
        {
            int N = int.Parse(Console.ReadLine());
            if(N == -1)
                return list;

            list.Add(N);
        }
    }

    static List<int> Divisor(int num)
    {
        List<int> divisors = new List<int>();

        for(int i = 1;  i <= Math.Sqrt(num); i++)
        {
            if(num % i == 0)
            {
                divisors.Add(i);
                // 중복 방지 && 자기 자신 방지
                if(i != num / i && num != num / i)
                {
                    divisors.Add(num / i);
                }
            }

        }

        divisors.Sort();

        return divisors;
    }
}
