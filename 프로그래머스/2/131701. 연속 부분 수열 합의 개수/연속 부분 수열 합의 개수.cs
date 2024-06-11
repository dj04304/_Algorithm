using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] elements)
    {
        int answer = 0;

        HashSet<int> lists = new HashSet<int>();


        int[] exElements = new int[elements.Length * 2];

        for(int i = 0; i < elements.Length; i++)
        {
            exElements[i] = elements[i];
            exElements[i + elements.Length] = elements[i];
        }
 
        for(int  length = 1; length <= elements.Length; length++)
        {
            for(int start = 0; start < elements.Length; start++)
            {
                int sum = 0;
                for(int i = 0; i < length; i++)
                {
                    sum += exElements[start + i];
                }
                lists.Add(sum);
            }
            // 1 -> 1, 7, 9, 4
            // 2 -> 16, 10, 2, 5, 11
            // 3 -> 17, 11, 6, 12 ,20
        }

        answer = lists.Count;

        return answer;
    }

}
