using System.Text;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]); 

            Queue<int> q = new Queue<int>();
            int count = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("<");

            for(int i = 1; i < N + 1; i++)
            {
                q.Enqueue(i);
            }

            while (q.Count != 0)
            {
                count++;
                if (count == K)
                {
                    if(q.Count == 1)
                    {
                        sb.Append(q.Dequeue());
                    }
                    else
                    {
                        sb.Append(q.Dequeue() + ", ");
                    }
                   count = 0;
                }
                else
                {
                    q.Enqueue(q.Dequeue());
                }
                
            }

            sb.Append(">");
            Console.WriteLine(sb.ToString());
        }
    }
}

