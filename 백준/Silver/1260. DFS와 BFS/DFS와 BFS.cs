using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    static int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    static List<int>[] graph = new List<int>[n[0] + 1];
    static bool[] isDFSVisited = new bool[n[0] + 1];
    static StringBuilder DFSsb = new StringBuilder();
    static StringBuilder BFSsb = new StringBuilder();

    static int pair = n[1]; 

    static void Main(string[] args)
    {
        for (int i = 1; i <= n[0]; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < pair; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            graph[a].Add(b);
            graph[b].Add(a);
        }

        for (int i = 1; i <= n[0]; i++)
        {
            graph[i].Sort();
        }

        DFS(n[2]);
        Console.WriteLine(DFSsb.ToString());

        BFS(n[2]);
        Console.WriteLine(BFSsb.ToString());
    }

    public static void DFS(int now)
    {
        isDFSVisited[now] = true;
        DFSsb.Append(now).Append(' ');

        foreach (int next in graph[now])
        {
            if (isDFSVisited[next])
                continue;

            DFS(next);
        }
    }

    public static void BFS(int start)
    {
        bool[] isVisited = new bool[n[0] + 1];

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        isVisited[start] = true;

        while(queue.Count > 0)
        {
            int now = queue.Dequeue();
            BFSsb.Append(now).Append(' ');

            foreach (int next in graph[now])
            {
                if (isVisited[next])
                    continue;

                queue.Enqueue(next);
                isVisited[next] = true;

            }
        }

    }

}
