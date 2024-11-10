using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 2 7 
        // 3 5
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int N = A[1] * B[1];
        int M = (A[0] * B[1]) + (B[0] * A[1]);

        int gcd = GCD(M, N);

        if(gcd == 1)
        {
            Console.WriteLine($"{M} {N}");
        }
        else
        {
            N = N / gcd;
            M = M / gcd; 
            
            Console.WriteLine($"{M} {N}");
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
}
