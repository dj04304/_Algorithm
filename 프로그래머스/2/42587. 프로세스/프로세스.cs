using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int MaxCount = 0;

    public int solution(int[] priorities, int location)
    {
        Queue<(int priority, int index)> queue = new Queue<(int, int)>();

        for(int i = 0; i < priorities.Length; i++)
        {
            queue.Enqueue((priorities[i], i));
        }

        int num = 0;

        while(queue.Count > 0)
        {
            var currentNum = queue.Dequeue();

            if (queue.Count > 0 && queue.Any(p => p.priority > currentNum.priority))
            {
                queue.Enqueue(currentNum);
            }
            else
            {
                num++;
                if(currentNum.index == location)
                {
                    return num;
                }
            }

        }

        return -1;
    }
}