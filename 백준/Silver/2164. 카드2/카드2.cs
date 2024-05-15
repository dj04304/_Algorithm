using System.Text;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Queue<int> queue = new Queue<int>();

            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                queue.Enqueue(i);
            }

            while(true)
            {
                if (queue.Count <= 1)
                {
                    Console.WriteLine(queue.Peek());
                    break;
                }

                queue.Dequeue();
                queue.Enqueue(queue.Dequeue());
            }
        }
    }
}

