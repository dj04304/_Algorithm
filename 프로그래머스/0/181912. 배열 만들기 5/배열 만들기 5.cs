using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l)
{
    List<int> answer = new List<int>();

    for(int i = 0; i < intStrs.Length; i++)
    {
        int n = 0;
        n = int.Parse(intStrs[i].Substring(s, l));

        if(n > k)
            answer.Add(n);

    }

    return answer.ToArray();
}
}