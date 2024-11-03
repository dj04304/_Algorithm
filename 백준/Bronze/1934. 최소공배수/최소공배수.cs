using System;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        int[] arrays = new int[T];
        for (int i = 0; i < T; i++)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            arrays[i] = LCM(inputs[0], inputs[1]);
        }

        for (int i = 0; i < T; i++)
        {
            Console.WriteLine(arrays[i]);
        }

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
