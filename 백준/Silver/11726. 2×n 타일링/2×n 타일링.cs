using System.Text;

class Program
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] dp = new int[n + 1];

        dp[1] = 1;
        if (n > 1)
            dp[2] = 2;

        for(int i = 3; i <= n; i++)
        {
                dp[i] = (dp[i - 1] + dp[i - 2]) % 10007;

        }

        Console.WriteLine(dp[n]);

    }

}
