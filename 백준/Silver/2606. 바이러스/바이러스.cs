using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    static int n = int.Parse(Console.ReadLine());
    static int pair = int.Parse(Console.ReadLine());
    static List<int>[] dfs = new List<int>[n + 1];
    static bool[] isVisited = new bool[n + 1];

    static int count = 0;

    static void Main(string[] args)
    {
        for (int i = 1; i <= n; i++)
        {
            dfs[i] = new List<int>();
        }

        for (int i = 0; i < pair; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            dfs[a].Add(b);
            dfs[b].Add(a);

        }

        DFS(1);
        Console.WriteLine(count - 1);
    }

    public static void DFS(int now)
    {
        isVisited[now] = true;
        count++;

        foreach (int next in dfs[now])
        {
            if (isVisited[next])
                continue;

            DFS(next);
        }
    }

}
