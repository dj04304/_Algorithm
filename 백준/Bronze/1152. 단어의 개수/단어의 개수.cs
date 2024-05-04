using System;

namespace CodeKata8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int result = arr.Length;

            foreach (string s in arr)
            {
                if(s == "")
                {
                    result--;
                }
            }


            Console.WriteLine(result);
        }
    }
}

