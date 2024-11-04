using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> lists = new List<int>();

        lists = Inputs();

        for(int num = 0; num < lists.Count; num++)
        {
            int target = lists[num];
            int count = 0;

            bool[] IsPrime = new bool[(target * 2) + 1];
            for (int i = 2; i <= target * 2; i++)
                IsPrime[i] = true;

            for(int i = 2; i * i <= target * 2; i++)
            {
                if (IsPrime[i])
                {
                    for(int j = i * i; j <= target * 2; j+=i)
                    {
                        IsPrime[j] = false;
                    }
                }
            }

            for (int i = target + 1; i <= target * 2; i++)
            {
                if (IsPrime[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

    }

    static List<int> Inputs()
    {
        List<int> lists = new List<int>();

        while (true)
        {
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
                return lists;

            lists.Add(input);

        }
    }

}
