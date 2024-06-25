using System;
using System.Text;

class Program
{
    
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        int[] lope = new int[input];

        for (int i = 0; i < input; i++)
        {
            lope[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(lope);

        int maxWeight = lope[0] * lope.Length;

        for(int i = 1; i < lope.Length;i++) 
        {
            if(maxWeight > 0)
                maxWeight = Math.Max(maxWeight, lope[i] * (lope.Length - i));
        }


        Console.WriteLine(maxWeight);

    }

    
}
