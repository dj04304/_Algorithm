using System.Text;

namespace CodeKata8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int count = int.Parse(Console.ReadLine());

            Stack<int> stacks = new Stack<int>();
            StringBuilder cw = new StringBuilder();

            for(int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                // push
                if(input.Contains("push"))
                {
                    int next = input.IndexOf(" ");
                    string nextNum = input.Substring(next + 1);

                    if(int.TryParse(nextNum, out next))
                        stacks.Push(next);
                }

                // top
                else if(input.Contains("top"))
                {
                    if(stacks.Count == 0)
                    {
                        cw.AppendLine("-1");
                    }
                    else
                    {
                        cw.Append(stacks.Peek() + "\n");
                    }
                }

                // pop
                else if (input.Contains("pop"))
                {
                    if(stacks.Count == 0)
                    {
                        cw.AppendLine("-1");
                    }
                    else
                    {
                        cw.Append(stacks.Pop() + "\n");
                    }
                }

                // empty
                else if (input.Contains("empty"))
                {
                    if (stacks.Count == 0)
                        cw.AppendLine("1");
                    else
                        cw.AppendLine("0");
                }

                //size
                else if (input.Contains("size"))
                {
                    cw.Append(stacks.Count + "\n");
                }
            }
            Console.WriteLine(cw.ToString());
        }
    }
}

