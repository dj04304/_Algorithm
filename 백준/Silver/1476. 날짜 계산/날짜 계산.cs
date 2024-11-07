using System;

class Program
{
    static void Main(string[] args)
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int E = inputs[0];
        int S = inputs[1];
        int M = inputs[2];

        Console.WriteLine(Result(E, S, M));
        
    }

    static int Result(int E, int S, int M)
    {
        int year = 1;
        int e = 1, s = 1, m = 1;

        while(!(e == E && s == S && m == M))
        {
            year++;
            e = (e % 15) + 1;
            s = (s % 28) + 1;
            m = (m % 19) + 1;
        }


        return year;
    }
}
