using System;
using System.Text;

class Program
{
    
    static void Main(string[] args)
    {
        int input =int.Parse(Console.ReadLine());

        int count = -1;

        if (input % 5 == 0)
            count = input / 5;
        else
        {
            for (int i = input / 5; i >= 0; i--)
            {
                int a = input - (i * 5);

                if (a % 2 == 0)
                {
                    count = i + (a / 2);
                    break;
                }
            }
        }
        Console.WriteLine(count);

    }

    
}
