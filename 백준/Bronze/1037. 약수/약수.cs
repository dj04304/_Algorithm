using System;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        int[] arrays = new int[T];

        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        arrays = inputs;

        if(T == 1)
            Console.WriteLine(arrays[0] * arrays[0]);
        else
        {
            Array.Sort(arrays);
            Console.WriteLine(arrays[0] * arrays[T - 1]);

        }


    }

}
