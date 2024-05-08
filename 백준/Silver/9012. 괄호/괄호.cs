namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int count = int.Parse(Console.ReadLine());

            // count만큼 루프
            for(int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                // 괄호가 ( 일 경우 push 아닐경우 pop하여 최종적으로 stack에 아무것도 없는 경우 참
                Stack<int> stack = new Stack<int>();
                bool isTrue = false;

                // 괄호가 쌍이 안맞을 경우 return
                if (input.Length % 2 != 0)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                // 괄호 체크
                for(int j = 0; j < input.Length; j++)
                {
                    if(!isTrue)
                    {
                        // 1. ( 일 경우 push
                        // 2. ) 일 경우 pop
                        if (input[j] == '(')
                        {
                            stack.Push(1);
                        }
                        else
                        {
                            if (stack.Count > 0)
                            {
                                stack.Pop();
                            }
                            else
                            {
                                isTrue = true;
                            }
                            
                        }
                    }
                }

                if (stack.Count > 0 || isTrue)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }

            }
        }
    }
}

