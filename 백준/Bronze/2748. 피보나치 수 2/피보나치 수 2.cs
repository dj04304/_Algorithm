using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());

        long result = 0;
        long first = 0;
        long second = 1;

        if(a == 0)
        {
            Console.WriteLine(0);
            return;
        }
        if(a == 1)
        {
            Console.WriteLine(1);
            return;
        }
        
        for (int i = 2; i <= a; i++)
        {
            result = first + second;

            first = second;
            second = result;
        }
        
        Console.WriteLine(result);

    }

}
