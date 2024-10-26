using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int gcd = GCD(a, b);
        int lcm = LCM(a, b);

        Console.WriteLine(gcd);
        Console.WriteLine(lcm);

    }

    static int GCD(int a, int b)
    {
        while(b != 0)
        {
            int r = a % b;
            a = b;
            b = r;

        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

}
