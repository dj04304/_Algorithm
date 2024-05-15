using System.Text;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            
            Stack<int> stack = new Stack<int>();
            int count = int.Parse(Console.ReadLine());

            int n = 1;

            bool isTrue = false;

            for(int j = 0; j < count; j++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!stack.Contains(num))
                {
                    for (int i = n; i <= num; i++)
                    {
                        if (i <= num)
                        {
                            stack.Push(i);
                            sb.AppendLine("+");

                            n++;
                        }
                    }

                }
                if (stack.Contains(num) && num == stack.Peek())
                {

                    stack.Pop();
                    sb.AppendLine("-");
                }
                else
                {
                    isTrue = true;
                }

            }

            if(isTrue)
                Console.WriteLine("NO");
            else
                Console.WriteLine(sb.ToString());
        } 
    }
}

