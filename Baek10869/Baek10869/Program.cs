using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baek10869
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split();

            int A = Convert.ToInt32(arr[0]);
            int B = Convert.ToInt32(arr[1]);

            if(A > 0 && B < 10000)
            {
                Console.WriteLine(A + B);
                Console.WriteLine(A - B);
                Console.WriteLine(A * B);
                Console.WriteLine(A / B);
                Console.WriteLine(A % B);
            }
        }
    }
}
