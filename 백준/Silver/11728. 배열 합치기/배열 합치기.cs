using System;

class Program
{
    static void Main(string[] args)
    {
        string[] arrays = Console.ReadLine().Split();

        int n = int.Parse(arrays[0]);
        int m = int.Parse(arrays[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] num = new int[n + m];
        List<int> list = new List<int>();

        for (int i = 0; i < n; i++)
        {
            list.Add(a[i]);
        }

        for(int i = 0;  i < m; i++)
        {
            list.Add(b[i]);
        }

        list.Sort();

        num = list.ToArray();

        Console.WriteLine(string.Join(' ', num));
    }

    
}
