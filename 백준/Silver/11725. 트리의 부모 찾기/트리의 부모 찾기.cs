using System;
using System.Text;

class Program
{
    static int n = int.Parse(Console.ReadLine());
    static List<int>[] graph = new List<int>[n + 1];
    static int[] parent = new int[n + 1];
    static StringBuilder sb = new StringBuilder();

    static void Main(string[] args)
    {
        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < n - 1;  i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int a = int.Parse(inputs[0]);
            int b= int.Parse(inputs[1]);

            graph[a].Add(b);
            graph[b].Add(a);
        }

        for (int i = 1; i <= n; i++)
        {
            graph[i].Sort();
        }

        BFS(1);

        for(int i = 2; i <= n; i++)
        {
            sb.AppendLine(parent[i].ToString());
        }

        Console.WriteLine(sb.ToString());
    }

    static void BFS(int start)
    {
        bool[] isVisited = new bool[n + 1];
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);

        isVisited[start] = true;
        
        while(queue.Count > 0)
        {
            int now = queue.Dequeue();

            foreach (int next in graph[now])
            {
                if (isVisited[next])
                    continue;

                queue.Enqueue(next);
                isVisited[next] = true;
                parent[next] = now;
            }

        }

    }


}
