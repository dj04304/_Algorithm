using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata60
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            string result = new string(word.Reverse().ToArray());

            if(result == word)
            {
                Console.WriteLine("1");
            }else
            {
                Console.WriteLine("0");
            }
 


        }

    }
}
