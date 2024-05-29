using System;

class Program
{
    static void Main(string[] args)
    {
        // 입력
        int count = int.Parse(Console.ReadLine());

        int[] arrays = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] dp = new int[count];
        
        for(int i = 0; i < count; i++)
            dp[i] = arrays[i];

        for(int i = 1;  i < count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arrays[i] > arrays[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + arrays[i]);
                }
            }
                
        }

        int result = dp.Max();

        Console.WriteLine(result);

    }
}
