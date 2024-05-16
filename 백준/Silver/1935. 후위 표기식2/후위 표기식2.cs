using System.Text;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            
            Stack<double> stack = new Stack<double>();

            int[] arr = new int[count];

            for(int i = 0; i < count; i++)
            {
                int a = int.Parse(Console.ReadLine());
                arr[i] = a;
            }

            int index = 0;

            foreach(char c in input)
            {
                if (input[index] == '+')
                {
                    double a = stack.Pop();
                    double b = stack.Pop();
                    stack.Push(b + a);
                }
                else if (input[index] == '-')
                {
                    double a = stack.Pop();
                    double b = stack.Pop();
                    stack.Push(b - a);
                }
                else if (input[index] == '*')
                {
                    double a = stack.Pop();
                    double b = stack.Pop();
                    stack.Push(b * a);
                }
                else if (input[index] == '/')
                {
                    double a = stack.Pop();
                    double b = stack.Pop();
                    stack.Push(b / a);
                }
                else
                {
                    stack.Push(arr[c - 'A']);
                }

                index++;
            }

            double result = stack.Peek();

            Console.WriteLine($"{result:F2}");

        }
    }
}

