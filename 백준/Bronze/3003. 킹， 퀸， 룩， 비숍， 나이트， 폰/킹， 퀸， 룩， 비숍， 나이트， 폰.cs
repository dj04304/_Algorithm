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
            int king = 1;
            int queen = 1;
            int rook = 2;
            int bishop = 2;
            int knight = 2;
            int pone = 8;

            int[] chess = new int[] { king, queen, rook, bishop, knight, pone};

            string input = Console.ReadLine();

            string[] splitInput = input.Split(' ');

            for(int i = 0; i < splitInput.Length; i++)
            {
                chess[i] -= int.Parse(splitInput[i]);
            }

            Console.WriteLine(string.Join(" ", chess));

        }
    }
}
