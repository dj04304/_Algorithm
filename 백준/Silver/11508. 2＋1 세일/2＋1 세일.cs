using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        int[] items = new int[input];

        for(int i = 0; i < input; i++)
        {
            items[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(items);
        Array.Reverse(items);

        int total = 0;

        for (int i = 0; i < input; i++)
        {
            if (i != 0 && (i + 1) % 3 == 0)
                continue;

            total += items[i];

        }

        Console.WriteLine(total);
    }

    
}
