using System.Text;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastPush = 0;
            int count = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            StringBuilder cw = new StringBuilder();

            for(int i = 0; i < count; i++) 
            {
                string[] input= Console.ReadLine().Split(" ");
            
                // push
                if(input.Contains("push"))
                {
                    lastPush = int.Parse(input[1]);
                    queue.Enqueue(lastPush);
                }
                else if(input.Contains("pop"))
                {
                    if(queue.Count == 0)
                        cw.AppendLine("-1");
                    else
                        cw.Append(queue.Dequeue() + "\n");
                }
                else if(input.Contains("size"))
                {
                    cw.Append(queue.Count() + "\n");
                }
                else if(input.Contains("empty"))
                {
                    if (queue.Count == 0)
                        cw.AppendLine("1");
                    else
                        cw.AppendLine("0");

                }
                else if(input.Contains("front"))
                {
                    if (queue.Count == 0)
                        cw.AppendLine("-1");
                    else
                    {
                        cw.Append(queue.Peek() + "\n");
                    }
                }
                else if (input.Contains("back"))
                {
                    if (queue.Count == 0)
                        cw.AppendLine("-1");
                    else
                    {
                        cw.Append(lastPush + "\n");
                    }
                }

            }

            Console.WriteLine(cw.ToString());
        }
    }
}

