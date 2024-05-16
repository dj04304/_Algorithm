using System.Text;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Stack<char> stack = new Stack<char>();

            string L = Console.ReadLine();
            //0100001011001101110011
            int stick = 0;
            int answer = 0;

            stack.Push(L[0]);

            for(int i = 1; i < L.Length; i++)
            {
                if (L[i] == '(')
                {
                    stack.Push(L[i]);
                }
                else if (L[i] == ')')
                {
                    stack.Pop();

                    //if (stack.Peek() == '(')
                    if (L[i-1] == '(')
                        answer += stack.Count;
                    else
                        answer++;

                }

            }
            Console.WriteLine(answer);
        }
    }
}

