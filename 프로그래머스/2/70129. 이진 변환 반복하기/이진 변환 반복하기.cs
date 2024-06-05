using System;
using System.Collections.Generic;
public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[2] ;

        string a = s;

        bool one = true;

        while (one)
        {
            int count = 0;

            if (a == "1")
            {
                one = false;
                break;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '0')
                {
                    answer[1]++;
                    continue;
                }
                else
                    count++;
            }

            a = Convert.ToString(count, 2);
            answer[0]++;

        }

        return answer;
    }
}