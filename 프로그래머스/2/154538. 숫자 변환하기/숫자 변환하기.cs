using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int x, int y, int n)
    {
        // BFS를 위한 큐 생성
        Queue<(int current, int steps)> queue = new Queue<(int, int)>();
        HashSet<int> visited = new HashSet<int>();

        // 시작점 추가
        queue.Enqueue((x, 0));
        visited.Add(x);

        // BFS 실행
        while (queue.Count > 0)
        {
            var (current, steps) = queue.Dequeue();

            // 목표에 도달한 경우
            if (current == y)
                return steps;

            // 다음 가능한 연산들
            List<int> nextSteps = new List<int>
            {
                current + n,
                current * 2,
                current * 3
            };

            foreach (var next in nextSteps)
            {
                // y를 초과하거나 이미 방문한 경우 건너뜀
                if (next > y || visited.Contains(next))
                    continue;

                // 큐에 추가하고 방문 표시
                queue.Enqueue((next, steps + 1));
                visited.Add(next);
            }
        }

        // 목표에 도달할 수 없는 경우
        return -1;
    }
}