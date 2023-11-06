using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baek10430
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split();

            int A = Int32.Parse(arr[0]);
            int B = Int32.Parse(arr[1]);
            int C = Int32.Parse(arr[2]);

            int result1 = (A + B) % C;
            int result2 = ((A % C) + (B % C)) % C;
            int result3 = (A * B) % C;
            int result4 = ((A % C) * (B % C)) % C;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

        }
    }
}
