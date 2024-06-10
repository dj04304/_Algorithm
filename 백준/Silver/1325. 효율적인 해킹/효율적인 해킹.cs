using System;
using System.Text;

class Program
{
    static StringBuilder sb = new StringBuilder();

    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');

        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        List<int>[] graph = new List<int>[n + 1];

        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < m;  i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int a = int.Parse(inputs[0]);
            int b= int.Parse(inputs[1]);

            graph[b].Add(a);
        }

        int[] hackingsCount = new int[n + 1];
        int maxCount = 0;

        for(int i  = 1; i <=n; i++)
        {
            bool[] isVisited = new bool[n + 1];
            int count = DFS(i, graph, isVisited);
            hackingsCount[i] = count;

            if(count > maxCount)
                maxCount = count;
        }

        List<int> result = new List<int>();

        for(int i = 1; i <= n; i++)
        {
            if (hackingsCount[i] == maxCount)
                result.Add(i);
        }

        result.Sort();
        Console.WriteLine(string.Join(" ", result));

    }

    static int DFS(int start, List<int>[] graph, bool[] isVisited)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(start);
        isVisited[start] = true;
        int count = 0;
        
        while(stack.Count > 0)
        {
            int now = stack.Pop();
            count++;

            foreach (int next in graph[now])
            {
                if (isVisited[next])
                    continue;

                stack.Push(next);
                isVisited[next] = true;
            }

        }

        return count;
    }


}
