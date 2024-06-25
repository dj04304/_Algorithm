using System;
using System.Text;

class Program
{
    
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        long[] tip = new long[input];

        long sum = 0;
        for(int i = 0; i < input; i++)
        {
            tip[i] = long.Parse(Console.ReadLine());
        }

        Array.Sort(tip);
        Array.Reverse(tip);

       for(int i = 0; i < input; i++)
        {
            long a = tip[i] - ((i+1) - 1);

            if (a < 0)
                continue;
            else
                sum += a;
        }

        Console.WriteLine(sum);

    }

    
}
