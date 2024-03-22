using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata60
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                    for (int j = 0; j < count - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (i - 1) * 2 + 1; j++)
                    {
                        Console.Write("*");
                    }
               
                Console.WriteLine();
            }

            for(int i = count - 1; i >= 1; i--)
            {
                for(int j = 0; j < count - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < (i-1) * 2 + 1 ; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
}
