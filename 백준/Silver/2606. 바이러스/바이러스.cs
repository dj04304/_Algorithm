using System;
using System.Collections.Generic;

class Solution
{
    static List<int>[] graph;
    static bool[] visited;

    static void Main()
    {
        int computer = int.Parse(Console.ReadLine());
        int connect = int.Parse(Console.ReadLine());

        //DFS
        graph = new List<int>[computer + 1];
        visited = new bool[computer + 1];

        int[,] edges = new int[connect, 2];

        for (int i = 0; i < connect; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            edges[i, 0] = a;
            edges[i, 1] = b;

        }

        for (int i = 0; i <= computer; i++)
            graph[i] = new List<int>();

        for (int i = 0; i < edges.GetLength(0); i++)
        {
            int a= edges[i, 0];
            int b = edges[i, 1];

            graph[a].Add(b);
            graph[b].Add(a);
        }

        DFS(1);

        int answer = 0;

        foreach(bool isInfected in visited)
        {
            if(isInfected)
                answer++;
        }

        Console.WriteLine(answer - 1);


    }

    static void DFS(int node)
    {
        visited[node] = true;
        foreach (int next in graph[node])
        {
            if (!visited[next])
                DFS(next);
        }


    }


}


