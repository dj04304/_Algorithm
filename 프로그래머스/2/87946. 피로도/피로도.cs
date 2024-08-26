using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int MaxCount = 0;

    public int solution(int k, int[,] dungeons)
    {
        bool[] visited = new bool[dungeons.GetLength(0)];
        Recursion(k, dungeons, visited, 0);
        // 필요 피로도보다 많거나 같다면
        return MaxCount;
    }

    public void Recursion(int k, int[,] dungeons, bool[] visited, int count)
    {
        MaxCount = Math.Max(MaxCount, count);

        for(int i = 0; i < dungeons.GetLongLength(0); i++)
        {
            if (!visited[i] && k >= dungeons[i, 0])
            {
                visited[i] = true;
                Recursion(k - dungeons[i, 1], dungeons, visited, count + 1);
                visited[i] = false;
            }
        }
    }
}